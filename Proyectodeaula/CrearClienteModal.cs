using DAL;
using ENTITY;
using System;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class CrearClienteModal : Form
    {
        ClienteService _clienteService;
        public delegate void ClienteCreadoHandler(Cliente cliente);
        public event ClienteCreadoHandler ClienteCreado;

        public CrearClienteModal(string cedula = "")
        {
            _clienteService = new ClienteService();
            InitializeComponent();
            txtCedula.Text = cedula;
            this.ActiveControl = null;

        }

        private async void btnCrearCliente_Click(object sender, EventArgs e)
        {
            // Validaciones usando la clase Validator
            if (!Validator.ValidarTexto(txtCedula.Text, 10) || txtCedula.Text.Length < 8)
            {
                MessageBox.Show("La cédula debe tener entre 8 y 10 caracteres.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidarTexto(txtNombre.Text, 100))
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(txtCorreo.Text) && !Validator.ValidarEmail(txtCorreo.Text))
            {
                MessageBox.Show("El formato del correo electrónico no es válido.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var cliente = new Cliente
                {
                    Cedula = txtCedula.Text,
                    Nombre = txtNombre.Text,
                    Telefono = txtTelefono.Text,
                    Correo = txtCorreo.Text
                };

                await _clienteService.CrearClienteAsync(cliente);
                MessageBox.Show("Cliente guardado correctamente.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClienteCreado?.Invoke(cliente);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela la entrada del carácter
            }
        }
    }
}