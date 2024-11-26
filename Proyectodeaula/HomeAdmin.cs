using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class HomeAdmin : Form
    {
        public HomeAdmin()
        {
            InitializeComponent();
        }

        private void HomeAdmin_Load(object sender, EventArgs e)
        {
            var inicio = new Inicio();
            AbrirFormhijo(inicio);
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

        private void btnProuctos_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new Productos());
        }

        private void btnCrearFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new CrearFactura());
        }

        private void btnGestionFactura_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new GestionFactura());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new GestionClientes());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            pReportes.Visible = !pReportes.Visible;
        }

        private void btnVentasMensuales_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new ReporteVentasMensuales());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new ReporteTopCliente());
        }

        private void btnReporteVendedores_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new ReporteTopVendedores());
        }

        private void btnGestionCliente_Click(object sender, EventArgs e)
        {
            AbrirFormhijo(new GestionUsuarios());
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
            pMenuFactura.Visible = ! pMenuFactura.Visible;
        }

        
    }
}
