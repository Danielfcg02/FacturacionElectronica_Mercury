using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class GestionClientes : Form
    {
        private ClienteService clienteService;
        private List<Cliente> clientes;
        private Cliente clienteSelecionado;
        public GestionClientes()
        {
            InitializeComponent();
            clienteService = new ClienteService();
        }

        private async void GestionClientes_Load(object sender, EventArgs e)
        {
            await CargarClientes();
        }

        private async Task CargarClientes()
        {
            clientes = await clienteService.GetAllClientesAsync();
            dgvClientes.DataSource = clientes;
            dgvClientes.ClearSelection();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClientes.Rows[e.RowIndex];

                lCedula.Text = row.Cells["Cedula"].Value?.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value?.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
                
                clienteSelecionado = new Cliente(lCedula.Text,txtNombre.Text,txtCorreo.Text,txtTelefono.Text);
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            var filtro = txtBuscarCliente.Text.ToLower();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                dgvClientes.DataSource = clientes;
            }
            else
            {
                var clientesFiltrados = clientes
                    .Where(p =>
                        p.Nombre.ToLower().Contains(filtro) ||
                        p.Correo.ToString().Contains(filtro) ||
                        p.Telefono.ToString().Contains(filtro))
                    .ToList();

                dgvClientes.DataSource = clientesFiltrados;
            }
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(lCedula.Text, txtNombre.Text, txtCorreo.Text, txtTelefono.Text);
            await clienteService.UpdateClienteAsync(cliente);
            limpiarDatos();
            MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            await CargarClientes();
        }

        private void limpiarDatos()
        {
            lCedula.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            CrearClienteModal productoForm = new CrearClienteModal();

            productoForm.FormClosed += async (s, args) => await CargarClientes();

            productoForm.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }
    }
}
