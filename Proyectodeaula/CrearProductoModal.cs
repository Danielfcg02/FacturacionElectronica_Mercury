using DAL;
using ENTITY;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class CrearProductoModal : Form
    {
        private ProductoService _productoService;
        public CrearProductoModal()
        {
            InitializeComponent();
            _productoService = new ProductoService();
            this.ActiveControl = null;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campo Nombre usando Validator
            if (!Validator.ValidarTexto(txtNombre.Text, 100))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            // Validación de campo Precio
            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio) ||
                !Validator.ValidarDecimalPositivo(precio))
            {
                MessageBox.Show("El campo 'Precio' debe ser un número válido mayor a 0.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
                return;
            }

            // Validación de campo Stock
            int stock;
            if (!int.TryParse(txtStock.Text, out stock) ||
                !Validator.ValidarEnteroPositivo(stock))
            {
                MessageBox.Show("El campo 'Stock' debe ser un número entero válido mayor a 0.",
                    "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStock.Focus();
                return;
            }

            // Validación de campo Talla
            if (!Validator.ValidarTexto(txtTalla.Text, 3, 1))
            {
                MessageBox.Show("El campo 'Talla' es obligatorio.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTalla.Focus();
                return;
            }

            try
            {
                await _productoService.CreateProducto(txtNombre.Text, txtDescripcion.Text,
                    precio, stock, txtTalla.Text);
                MessageBox.Show("Producto creado con éxito.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de guardar
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();
                txtDescripcion.Clear();
                txtTalla.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el producto: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, punto decimal y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains('.'))
            {
                e.Handled = true;
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}