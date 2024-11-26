using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class HomeEmpleado : Form
    {
        public HomeEmpleado()
        {
            InitializeComponent();
        }

        private void HomeEmpleado_Load(object sender, EventArgs e)
        {
            var inicio = new Inicio();
            AbrirFormhijo(inicio);
        }

        private void btnCrearFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new CrearFactura());
        }

        private void btnConsultarFactura_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new GestionFactura());
        }

        private void AbrirFormhijo(object formhijo)
        {
            if (this.pContenedor.Controls.Count > 0)
                this.pContenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContenedor.Controls.Add(fh);
            this.pContenedor.Tag = fh;
            fh.Show();
        }



        //Controles del from
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestVent_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestVent.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestVent.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenuFactura_Click(object sender, EventArgs e)
        {
            pMenuFactura.Visible = !pMenuFactura.Visible;
        }

    }
}
