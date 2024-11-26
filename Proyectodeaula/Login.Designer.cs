namespace Proyectodeaula
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestVent = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.MenuVertical = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContenedor = new System.Windows.Forms.Panel();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestVent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.MenuVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.BarraTitulo.Controls.Add(this.btnRestVent);
            this.BarraTitulo.Controls.Add(this.btnMaximizar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1200, 26);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnRestVent
            // 
            this.btnRestVent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestVent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestVent.Image = ((System.Drawing.Image)(resources.GetObject("btnRestVent.Image")));
            this.btnRestVent.Location = new System.Drawing.Point(1137, 2);
            this.btnRestVent.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestVent.Name = "btnRestVent";
            this.btnRestVent.Size = new System.Drawing.Size(29, 24);
            this.btnRestVent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestVent.TabIndex = 2;
            this.btnRestVent.TabStop = false;
            this.btnRestVent.Visible = false;
            this.btnRestVent.Click += new System.EventHandler(this.btnRestVent_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1137, 2);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(29, 24);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1105, 2);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(29, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1170, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(29, 24);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // MenuVertical
            // 
            this.MenuVertical.BackColor = System.Drawing.Color.Black;
            this.MenuVertical.Controls.Add(this.label4);
            this.MenuVertical.Controls.Add(this.pictureBox1);
            this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVertical.Location = new System.Drawing.Point(0, 26);
            this.MenuVertical.Margin = new System.Windows.Forms.Padding(2);
            this.MenuVertical.Name = "MenuVertical";
            this.MenuVertical.Size = new System.Drawing.Size(275, 574);
            this.MenuVertical.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 26.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.label4.Location = new System.Drawing.Point(51, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 57);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mercury";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 185);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContenedor
            // 
            this.PanelContenedor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.PanelContenedor.Controls.Add(this.BtnRegistrar);
            this.PanelContenedor.Controls.Add(this.txtPassword);
            this.PanelContenedor.Controls.Add(this.txtUserName);
            this.PanelContenedor.Controls.Add(this.label2);
            this.PanelContenedor.Controls.Add(this.label3);
            this.PanelContenedor.Controls.Add(this.label1);
            this.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedor.Location = new System.Drawing.Point(275, 26);
            this.PanelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.PanelContenedor.Name = "PanelContenedor";
            this.PanelContenedor.Size = new System.Drawing.Size(925, 574);
            this.PanelContenedor.TabIndex = 4;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.FlatAppearance.BorderSize = 0;
            this.BtnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.BtnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.BtnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(29)))));
            this.BtnRegistrar.Location = new System.Drawing.Point(301, 405);
            this.BtnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(358, 40);
            this.BtnRegistrar.TabIndex = 6;
            this.BtnRegistrar.Text = "Iniciar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(29)))));
            this.txtPassword.Location = new System.Drawing.Point(301, 323);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(358, 30);
            this.txtPassword.TabIndex = 5;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(29)))));
            this.txtUserName.Location = new System.Drawing.Point(301, 184);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(358, 30);
            this.txtUserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(29)))));
            this.label2.Location = new System.Drawing.Point(295, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(29)))));
            this.label3.Location = new System.Drawing.Point(295, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(48)))), ((int)(((byte)(29)))));
            this.label1.Location = new System.Drawing.Point(386, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar Sesión";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.PanelContenedor);
            this.Controls.Add(this.MenuVertical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestVent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.MenuVertical.ResumeLayout(false);
            this.MenuVertical.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContenedor.ResumeLayout(false);
            this.PanelContenedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVertical;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelContenedor;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnRestVent;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label label4;
    }
}

