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
    public partial class GestionUsuarios : Form
    {
        private UsuarioService usuarioService;
        private List<Usuario> usuarios;
        Usuario usuarioSelecionado;

        public GestionUsuarios()
        {
            InitializeComponent();
        }

        private void GestionUsuarios_Load(object sender, EventArgs e)
        {
            usuarioService = new UsuarioService();
            CargarUsuarios();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearUsuarioModal crearUsuarioModal = new CrearUsuarioModal();
            crearUsuarioModal.ShowDialog();
        }

        private async void CargarUsuarios()
        {
            usuarios = await usuarioService.GetAllUsuariosAsync();
            dgvEmpleados.DataSource = usuarios;
            dgvEmpleados.ClearSelection();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
                DataGridViewRow row = dgvEmpleados.Rows[e.RowIndex];
                string cedula= Convert.ToString(row.Cells["cedula"].Value);

                usuarioSelecionado = usuarios.FirstOrDefault(v => v.Cedula == cedula);

                btnEliminar.Enabled = true;

                lCedula.Text=usuarioSelecionado.Cedula;
                txtUser.Text=usuarioSelecionado.UserName;
                txtContraseña.Text=usuarioSelecionado.Password;
                txtNombre.Text=usuarioSelecionado.Name;
                txtTelefono.Text=usuarioSelecionado.Phone;
                txtCorreo.Text=usuarioSelecionado.Email;

            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            usuarioSelecionado.Cedula = lCedula.Text;
            usuarioSelecionado.UserName = txtUser.Text;
            usuarioSelecionado.Password = txtContraseña.Text;
            usuarioSelecionado.Name = txtNombre.Text;
            usuarioSelecionado.Phone = txtTelefono.Text;
            usuarioSelecionado.Email = txtCorreo.Text;

            await usuarioService.UpdateUsuarioAsync(usuarioSelecionado);
            CargarUsuarios();

            MessageBox.Show("Usuario actualizado correctamente" , "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await usuarioService.DeleteUsuarioAsync(usuarioSelecionado.Cedula);
        }
    }
}
