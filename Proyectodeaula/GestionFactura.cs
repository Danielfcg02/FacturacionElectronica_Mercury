using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class GestionFactura : Form
    {
        private FacturaService _facturaService;

        private Factura _facturaSeleccionada;
        private Venta _ventaSeleccionada;

        private List<Factura> _facturas;
        private List<Venta> _ventasEliminar;

        private Dictionary<int, int> _cantidadesOriginales = new Dictionary<int, int>();

        public GestionFactura()
        {
            InitializeComponent();
        }

        private async void GestionFactura_Load(object sender, EventArgs e)
        {
            _facturaService = new FacturaService();
            _ventasEliminar = new List<Venta>();

            dtpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            dtpFin.Value = DateTime.Now;

            dtpFin.MaxDate = DateTime.Now;
            dtpInicio.MaxDate = DateTime.Now;
            _facturas = await _facturaService.GetFacturasByFecha(dtpInicio.Value, dtpFin.Value);
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            dgvFacturas.DataSource = null;
            if(_facturas != null)
            {
                dgvFacturas.DataSource = _facturas.Select(f => new
                {
                    f.Id,
                    Cliente = f.Cliente.Nombre,
                    total = NumberFormatter.FormatWithSuffix(f.Total),
                    Fecha = f.FechaCreacion.ToString("dd/MM/yyyy")
                }).ToList();
                dgvFacturas.ClearSelection();
                dgvFacturas.Visible = true;
            }
            
        }

        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            //var filtro = txtBuscarFactura.Text.ToLower();

            //if (string.IsNullOrWhiteSpace(filtro))
            //{
            //    dgvFacturas.DataSource = _facturas;
            //}
            //else
            //{
            //    var facturasFiltradas = _facturas
            //        .Where(f =>
            //            f.Cliente.Nombre.ToLower().Contains(filtro) ||
            //            f.Id.ToString().Contains(filtro))
            //        .ToList();

            //    dgvFacturas.DataSource = facturasFiltradas;
            //}
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LimpiarFormulario();
                pModificarVenta.Visible = true;
                btnImprimir.Enabled = true;
                DataGridViewRow row = dgvFacturas.Rows[e.RowIndex];
                string facturaId = Convert.ToString(row.Cells["Id"].Value);

                _facturaSeleccionada = _facturas.FirstOrDefault(f => f.Id == facturaId);

                if (_facturaSeleccionada != null)
                {
                    CargarDetallesFactura();
                }
            }
        }

        private async void CargarDetallesFactura()
        {
            dgvVentas.DataSource = null;
            if (_facturaSeleccionada.Ventas == null || !_facturaSeleccionada.Ventas.Any())
            {
                _facturaSeleccionada.Ventas = await _facturaService.GetVentasByFacturaId(_facturaSeleccionada.Id);
                pDatosCliente.Visible = true;
            }
            
            dgvVentas.DataSource = _facturaSeleccionada.Ventas.Select(v => new
            {
                v.Id,
                Producto = v.Producto.Nombre,
                Cantidad = v.Quantity,
                v.Subtotal,
            }).ToList();
            dgvVentas.Columns["Id"].Visible = false;
            dgvVentas.ClearSelection();

            lCedula.Text = _facturaSeleccionada.Cliente.Cedula;
            lNombre.Text = _facturaSeleccionada.Cliente.Nombre;
            lTelefono.Text = _facturaSeleccionada.Cliente.Telefono;
            lCorreo.Text = _facturaSeleccionada.Cliente.Correo;

        }

        private void LimpiarFormulario()
        {
            _facturaSeleccionada = null;
            dgvVentas.DataSource = null;

            lCedula.Text = "Cédula";
            lNombre.Text = "Nombre";
            lTelefono.Text = "Teléfono";
            lCorreo.Text = "Correo";

            txtCantidad.Text = string.Empty;
            lSubPrecio.Text = "0.00";
        }

        private async void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            _facturas = await _facturaService.GetFacturasByFecha(dtpInicio.Value, dtpFin.Value);
            CargarFacturas();
        }

        private async void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            _facturas = await _facturaService.GetFacturasByFecha(dtpInicio.Value, dtpFin.Value);
            CargarFacturas();
        }

        private void dgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvVentas.Rows[e.RowIndex];
                int ventaId = Convert.ToInt32(row.Cells["Id"].Value);

                _ventaSeleccionada = _facturaSeleccionada.Ventas.FirstOrDefault(v => v.Id == ventaId);
                
                if (!_cantidadesOriginales.ContainsKey(ventaId))
                {
                    _cantidadesOriginales[ventaId] = _ventaSeleccionada.Quantity; // Guarda la cantidad original
                }


                txtCantidad.Text = _ventaSeleccionada.Quantity.ToString();
                btnEliminar.Enabled = true;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            ActualizarSubtotal();   
        }

        private void ActualizarSubtotal()
        {
            if (_ventaSeleccionada != null && int.TryParse(txtCantidad.Text, out int nuevaCantidad))
            {
                int stockDisponible = _ventaSeleccionada.Producto.Stock;

                // Obtener la cantidad original desde el diccionario
                int cantidadOriginal = _cantidadesOriginales[_ventaSeleccionada.Id];
                int cantidadPermitida = stockDisponible + cantidadOriginal;

                if (nuevaCantidad > cantidadPermitida)
                {
                    MessageBox.Show("La cantidad a vender no puede ser mayor al stock disponible.", "Cantidad Excedida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nuevaCantidad = cantidadPermitida;
                    txtCantidad.Text = nuevaCantidad.ToString();
                }

                double subtotal = nuevaCantidad * _ventaSeleccionada.Producto.Precio;

                lSubPrecio.Text = NumberFormatter.FormatWithSuffix(subtotal);
                _ventaSeleccionada.Subtotal = subtotal;
                _ventaSeleccionada.Quantity = nuevaCantidad;
                _facturaSeleccionada.Total = _facturaSeleccionada.Ventas.Sum(v => v.Subtotal);
                CargarFacturas();
                btnGuardar.Enabled = true;
            }
            else
            {
                lSubPrecio.Text = "0.00";
            }
        }


        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var venta in _facturaSeleccionada.Ventas)
                {
                    if (venta.Id != 0)
                    {
                        await _facturaService.ActualizarVentaFacturas(_facturaSeleccionada.Ventas);
                    }
                    else
                    {
                        await _facturaService.AddVenta(venta, _facturaSeleccionada.Id);
                    }
                }

                foreach (var venta in _ventasEliminar)
                {
                    //await _facturaService.
                }

                MessageBox.Show("Venta actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                _facturas = await _facturaService.GetFacturasByFecha(dtpInicio.Value, dtpFin.Value);
                CargarFacturas();
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al guardar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_ventaSeleccionada != null)
            {
                if (_facturaSeleccionada.Ventas.Count == 1)
                {
                    var result = MessageBox.Show("Se eliminará la factura porque no quedan ventas. ¿Desea continuar?",
                                                   "Advertencia",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Warning);
                    if (result == DialogResult.No)
                    {
                        return; // Cancelar la eliminación
                    }

                    await _facturaService.DeleteFactura(int.Parse(_facturaSeleccionada.Id));
                    _facturas = await _facturaService.GetFacturasByFecha(dtpInicio.Value,dtpFin.Value);
                    CargarFacturas();
                    LimpiarFormulario();
                    return;
                }

                _ventasEliminar.Add(_ventaSeleccionada);
                _facturaSeleccionada.Ventas.Remove(_ventaSeleccionada);
                _facturaSeleccionada.Total = _facturaSeleccionada.Ventas.Sum(v => v.Subtotal);
                CargarDetallesFactura();
                CargarFacturas();

                btnEliminar.Enabled = false;
                _ventaSeleccionada = null;
            }
            else
            {
                MessageBox.Show("No hay ninguna venta seleccionada para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
            _facturas = await _facturaService.GetFacturasByFecha(dtpInicio.Value, dtpFin.Value);
            CargarFacturas();
            pDatosCliente.Visible = false;
            pModificarVenta.Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            CrearFactura crearFacturaForm = new CrearFactura(_facturaSeleccionada);
            crearFacturaForm.ShowDialog();
            _facturaSeleccionada.Total = _facturaSeleccionada.Ventas.Sum(_ => _.Subtotal);
            CargarFacturas();
            CargarDetallesFactura();

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ignorar el carácter no permitido
            }
        }

        private void txtCantidad_Leave(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            InvoicePrinter printer = new InvoicePrinter(_facturaSeleccionada);
            printer.Print();
        }
    }
}
