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
    public partial class CrearUsuarioModal : Form
    {
        private UsuarioService usarioService;

        public CrearUsuarioModal()
        {
            InitializeComponent();
            usarioService = new UsuarioService();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de campo Cédula
            if (!Validator.ValidarTexto(txtCedula.Text, 10))
            {
                MessageBox.Show("El campo 'Cédula' es obligatorio y debe tener un formato válido.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCedula.Focus();
                return;
            }

            // Validación de campo Usuario
            if (!Validator.ValidarTexto(txtUser.Text, 50))
            {
                MessageBox.Show("El campo 'User' es obligatorio.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                return;
            }

            // Validación de campo Contraseña
            if (!Validator.ValidarTexto(txtContraseña.Text, 100))
            {
                MessageBox.Show("El campo 'Contraseña' es obligatorio.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Focus();
                return;
            }

            // Validación de campo Nombre
            if (!Validator.ValidarTexto(txtNombre.Text, 100))
            {
                MessageBox.Show("El campo 'Nombre' es obligatorio.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
                return;
            }

            // Validación de campo Teléfono (debe ser un número válido)
            if (!long.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length < 7)
            {
                MessageBox.Show("El campo 'Teléfono' debe ser un número válido.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            // Validación de campo Correo
            if (!Validator.ValidarEmail(txtCorreo.Text))
            {
                MessageBox.Show("El campo 'Correo' debe tener un formato de correo electrónico válido.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
                return;
            }

            try
            {
                // Aquí agregarías el código para guardar los datos del usuario
                MessageBox.Show("Usuario creado con éxito.", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Usuario usuario = new Usuario(
                                                txtCedula.Text,
                                                txtNombre.Text,
                                                txtUser.Text,
                                                txtCorreo.Text,
                                                txtContraseña.Text,
                                                "EMPLEADO",
                                                txtTelefono.Text
                                                );
                await usarioService.AddUsuario(usuario);

                // Limpiar los campos después de guardar
                txtCedula.Clear();
                txtUser.Clear();
                txtContraseña.Clear();
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
