using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class CrearFactura : Form
    {
        private ProductoService _productoService;
        private ClienteService _clienteService;
        private FacturaService _facturaService;
        
        private List<Producto> _productos;
        private List<Venta> _ventas;
        
        private Venta _ventaSeleccionada;
        private Producto _productoSeleccionado;
        private Cliente cliente;
        private Factura _factura;



        public CrearFactura(Factura factura=null)
        {
            InitializeComponent();
            this._factura = factura;
        }

        private async void CrearFactura_Load(object sender, EventArgs e)
        {
            _productoService = new ProductoService();
            _clienteService = new ClienteService();
            _productos = await _productoService.GetAllProductos(false);
            _ventas = new List<Venta>();
            _facturaService = new FacturaService();
            if (_factura != null)
            {
                CargarVentasFactura();
            }
            CargarProductos();
        }

        private void CargarProductos()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = _productos;
            dgvProductos.ClearSelection();
        }

        private void CargarVentasFactura()
        {
            _ventas = _factura.Ventas.ToList(); 
            cliente = _factura.Cliente; 
            lNombre.Text = cliente.Nombre; 
            lTelefono.Text = cliente.Telefono; 
            lCorreo.Text = cliente.Correo; 

            foreach (var venta in _ventas)
            {
                var productoAEliminar = _productos.FirstOrDefault(p => p.Id == venta.Producto.Id);
                if (productoAEliminar != null)
                {
                    _productos.Remove(productoAEliminar); 
                }
            }
            btnEliminar.Visible= false;
            pCliente.Visible= false;
            lbTotal.Visible= false;
            lTotal.Visible= false;
            btnGuardar.Text = "Confirmar";
            btnCancelar.Visible= true;
            CargarVentas();
        }


        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtBuscarProducto.Text.ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvProductos.DataSource = _productos;
            }
            else
            {
                var productosFiltrados = _productos
                    .Where(p =>
                        p.Nombre.ToLower().Contains(filtro) ||
                        p.Id.ToString().Contains(filtro) ||
                        p.Precio.ToString().Contains(filtro))
                    .ToList();

                dgvProductos.DataSource = productosFiltrados;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarCliente.Text.Length >= 8 && txtBuscarCliente.Text.Length <= 10)
            {
                BuscarCliente(txtBuscarCliente.Text);
            }
            else
            {
                LimpiarCampos();
                btnCrearCliente.Visible = false;
            }
        }

        private async void BuscarCliente(string cedula)
        {
            try
            {
                var cliente = await _clienteService.GetClienteByCedulaAsync(cedula);
                if (cliente != null)
                {
                    lNombre.Text = cliente.Nombre;
                    lTelefono.Text = cliente.Telefono;
                    lCorreo.Text = cliente.Correo;
                    btnCrearCliente.Visible = false;
                    pDatosCliente.Visible = true;
                    this.cliente = cliente;
                }
                else
                {
                    LimpiarCampos();
                    btnCrearCliente.Visible = true;
                    pDatosCliente.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar el cliente: {ex.Message}");
            }
        }

        private void LimpiarCampos()
        {
            lTelefono.Text = "Teléfono";
            lCorreo.Text = "Correo";
        }


        private void btnCrearCliente_Click_1(object sender, EventArgs e)
        {
            CrearClienteModal clienteModalForm = new CrearClienteModal(txtBuscarCliente.Text);

            clienteModalForm.ClienteCreado += CrearClienteModal_ClienteCreado;

            clienteModalForm.ShowDialog();
        }

        private void CrearClienteModal_ClienteCreado(Cliente cliente)
        {
            lNombre.Text = cliente.Nombre;
            lTelefono.Text = cliente.Telefono;
            lCorreo.Text = cliente.Correo;
            btnCrearCliente.Visible = false;
            pDatosCliente.Visible= true;
            this.cliente = cliente;
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            if (_productoSeleccionado != null)
            {
                Venta nuevaVenta = new Venta(_productoSeleccionado, int.Parse(txtCantidad.Text), NumberFormatter.ParseFromSuffix(lSubPrecio.Text));
                _ventas.Add(nuevaVenta);

                var productoAEliminar = _productos.FirstOrDefault(p => p.Id == _productoSeleccionado.Id);
                if (productoAEliminar != null)
                {
                    _productos.Remove(productoAEliminar);
                }

                _productoSeleccionado = null;
                btnAgregarVenta.Enabled = false;
                txtCantidad.Text = "";
                lSubPrecio.Text = "0.00";

                double total = _ventas.Sum(v => v.Subtotal);
                lTotal.Text = total.ToString("0.00");

                CargarVentas();
                CargarProductos(); 
            }
            else
            {
                MessageBox.Show("Seleccione un producto antes de agregar una venta.");
            }
        }


        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                _productoSeleccionado = new Producto
                {
                    Id = Convert.ToInt32(row.Cells[0].Value),
                    Nombre = row.Cells[1].Value?.ToString(),
                    Precio = Convert.ToDouble(row.Cells[2].Value),
                    Stock = Convert.ToInt32(row.Cells[3].Value),
                    Descripcion = row.Cells[4].Value?.ToString()
                };
                txtCantidad.Text = "1";
                ActualizarSubtotal();
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarSubtotal();
        }

        private void ActualizarSubtotal()
        {
            if (_productoSeleccionado != null && int.TryParse(txtCantidad.Text, out int cantidad))
            {
                if (cantidad > _productoSeleccionado.Stock)
                {
                    MessageBox.Show("La cantidad a vender no puede ser mayor al stock disponible.", "Cantidad Excedida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCantidad.Text = _productoSeleccionado.Stock.ToString();
                    cantidad = _productoSeleccionado.Stock;

                    return;
                }
                else
                {
                    btnAgregarVenta.Enabled = true;
                }

                double subtotal = cantidad * _productoSeleccionado.Precio;
                lSubPrecio.Text = NumberFormatter.FormatWithSuffix( subtotal );
            }
            else
            {
                lSubPrecio.Text = "0.00";
            }
        }


        private void CargarVentas()
        {
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = _ventas.Select(v => new
            {
                Producto = v.Producto.Nombre,
                cantidad = v.Quantity,
                v.Subtotal
            }).ToList();
            dgvVentas.ClearSelection();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
                int ventaId = Convert.ToInt32(row.Cells["Id"].Value);

                _ventaSeleccionada = _ventas.FirstOrDefault(v => v.Id == ventaId);

                btnEliminar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_ventaSeleccionada != null)
            {
                Producto productoARegresar = _ventaSeleccionada.Producto;
                _productos.Add(productoARegresar);

                _productos = _productos.OrderBy(p => p.Id).ToList(); // Ordena la lista por Id

                _ventas.Remove(_ventaSeleccionada);

                _ventaSeleccionada = null;
                btnEliminar.Enabled = false;

                CargarVentas();
                CargarProductos();
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (_factura != null)
                {
                    _factura.Ventas = _ventas;
                    Close();
                    return;
                }
                // Verificar si hay ventas y cliente seleccionado
                if (_ventas == null || _ventas.Count == 0)
                {
                    MessageBox.Show("No hay ventas agregadas a la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cliente == null)
                {
                    MessageBox.Show("No se ha seleccionado un cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Factura factura = new Factura(Session.user, cliente, _ventas);

                string message = await _facturaService.AddFactura(factura);
                MessageBox.Show("Factura guardada exitosamente.", message, MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LimpiarFormulario()
        {
            _ventas.Clear();
            _productoSeleccionado = null;
            _ventaSeleccionada = null;

            dgvVentas.DataSource = null;
            lTotal.Text = "0.00";

            _productos = await _productoService.GetAllProductos(false);
            CargarProductos();

            
            txtBuscarCliente.Text = "";
            pDatosCliente.Visible = false;
            btnCrearCliente.Visible = false;
            cliente = null;

            txtBuscarProducto.Text = "";
            txtCantidad.Text = "";
            lSubPrecio.Text = "0.00";
            btnAgregarVenta.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
