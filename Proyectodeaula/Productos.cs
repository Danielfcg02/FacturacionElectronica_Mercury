using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class Productos : Form
    {
        private ProductoService _productoService;
        private Producto _productoSeleccionado;
        private List<Producto> _productos;
        public Productos()
        {
            InitializeComponent();
            _productoService = new ProductoService();
        }

        private async void Productos_Load(object sender, EventArgs e)
        {
            await CargarProductos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearProductoModal productoForm = new CrearProductoModal();

            productoForm.FormClosed += async (s, args) => await CargarProductos();

            productoForm.ShowDialog();
        }

        private async Task CargarProductos()
        {
            _productos = await _productoService.GetAllProductos();
            dgvProductos.DataSource = _productos;
            dgvProductos.Columns["Descripcion"].Visible = false;
            dgvProductos.ClearSelection();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el índice de fila sea válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProductos.Rows[e.RowIndex];

                lId.Text = row.Cells["Id"].Value?.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtPrecio.Text = row.Cells["Precio"].Value?.ToString();
                txtStock.Text = row.Cells["Stock"].Value?.ToString();
                txtDescripcion.Text = row.Cells["Descripcion"].Value?.ToString();
                txtTalla.Text = row.Cells["Talla"].Value?.ToString();


                _productoSeleccionado = new Producto(int.Parse(lId.Text),txtNombre.Text,txtDescripcion.Text, double.Parse(txtPrecio.Text),int.Parse(txtStock.Text));
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await _productoService.DeleteProductoAsync(_productoSeleccionado.Id);
            await CargarProductos();
            LimpiarCampos();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!double.TryParse(txtPrecio.Text, out double precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número válido mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!int.TryParse(txtStock.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero válido mayor o igual a cero.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            _productoSeleccionado.Nombre = txtNombre.Text;
            _productoSeleccionado.Descripcion = txtDescripcion.Text;
            _productoSeleccionado.Precio = precio;
            _productoSeleccionado.Stock = stock;
            _productoSeleccionado.Talla = txtTalla.Text;

            try
            {
                
                await _productoService.UpdateProducto(_productoSeleccionado);
                await CargarProductos();
                LimpiarCampos();
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            lId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtTalla.Text = string.Empty;

            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;

            _productoSeleccionado = null;
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

    }
}
