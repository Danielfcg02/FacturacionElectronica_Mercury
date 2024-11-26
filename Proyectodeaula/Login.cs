using ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyectodeaula
{
    public partial class Login : Form
    {
        private UsuarioService usuarioService;

        public Login()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            usuarioService = new UsuarioService();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestVent.Visible = true;

        }

        private void btnRestVent_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestVent.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;  
            string password = txtPassword.Text;  


            Usuario usuario = await usuarioService.GetUsuarioByUserNameAsync(userName);
            
            if (usuario != null && usuario.Password == password)
            {
                Session.user = usuario;
                
                this.Hide();
                if (usuario.Role == "admin")
                {
                    HomeAdmin vp = new HomeAdmin();
                    vp.Show();
                }
                else
                {
                    HomeEmpleado vp = new HomeEmpleado();
                    vp.Show();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
