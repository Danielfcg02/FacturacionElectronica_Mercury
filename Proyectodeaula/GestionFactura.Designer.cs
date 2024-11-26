namespace Proyectodeaula
{
    partial class GestionFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pDatosCliente = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lCedula = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lCorreo = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pModificarVenta = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lSubPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lPrecio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pDatosCliente.SuspendLayout();
            this.pModificarVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion de facturas";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToResizeColumns = false;
            this.dgvFacturas.AllowUserToResizeRows = false;
            this.dgvFacturas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(201)))));
            this.dgvFacturas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 135);
            this.dgvFacturas.MultiSelect = false;
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.ReadOnly = true;
            this.dgvFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacturas.Size = new System.Drawing.Size(467, 423);
            this.dgvFacturas.TabIndex = 2;
            this.dgvFacturas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFacturas_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Filtrar facturas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.pModificarVenta);
            this.panel1.Controls.Add(this.dgvVentas);
            this.panel1.Location = new System.Drawing.Point(485, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 500);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pDatosCliente);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 321);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(453, 173);
            this.panel3.TabIndex = 22;
            // 
            // pDatosCliente
            // 
            this.pDatosCliente.Controls.Add(this.label3);
            this.pDatosCliente.Controls.Add(this.lCedula);
            this.pDatosCliente.Controls.Add(this.label10);
            this.pDatosCliente.Controls.Add(this.lCorreo);
            this.pDatosCliente.Controls.Add(this.lTelefono);
            this.pDatosCliente.Controls.Add(this.lNombre);
            this.pDatosCliente.Controls.Add(this.label6);
            this.pDatosCliente.Controls.Add(this.label5);
            this.pDatosCliente.Controls.Add(this.label4);
            this.pDatosCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDatosCliente.Location = new System.Drawing.Point(0, 0);
            this.pDatosCliente.Name = "pDatosCliente";
            this.pDatosCliente.Size = new System.Drawing.Size(453, 173);
            this.pDatosCliente.TabIndex = 11;
            this.pDatosCliente.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(209, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Cliente";
            // 
            // lCedula
            // 
            this.lCedula.AutoSize = true;
            this.lCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCedula.Location = new System.Drawing.Point(299, 40);
            this.lCedula.Name = "lCedula";
            this.lCedula.Size = new System.Drawing.Size(59, 20);
            this.lCedula.TabIndex = 17;
            this.lCedula.Text = "Cedula";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(105, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cedula";
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorreo.Location = new System.Drawing.Point(299, 129);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(57, 20);
            this.lCorreo.TabIndex = 15;
            this.lCorreo.Text = "Correo";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(297, 99);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(71, 20);
            this.lTelefono.TabIndex = 14;
            this.lTelefono.Text = "Telefono";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(299, 69);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(65, 20);
            this.lNombre.TabIndex = 13;
            this.lNombre.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(105, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(105, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(105, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // pModificarVenta
            // 
            this.pModificarVenta.Controls.Add(this.btnImprimir);
            this.pModificarVenta.Controls.Add(this.btnCancelar);
            this.pModificarVenta.Controls.Add(this.btnGuardar);
            this.pModificarVenta.Controls.Add(this.btnAgregar);
            this.pModificarVenta.Controls.Add(this.btnEliminar);
            this.pModificarVenta.Controls.Add(this.lSubPrecio);
            this.pModificarVenta.Controls.Add(this.txtCantidad);
            this.pModificarVenta.Controls.Add(this.lPrecio);
            this.pModificarVenta.Controls.Add(this.label8);
            this.pModificarVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.pModificarVenta.Location = new System.Drawing.Point(0, 229);
            this.pModificarVenta.Name = "pModificarVenta";
            this.pModificarVenta.Size = new System.Drawing.Size(453, 92);
            this.pModificarVenta.TabIndex = 21;
            this.pModificarVenta.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(194, 59);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(80, 30);
            this.btnImprimir.TabIndex = 36;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancelar.Location = new System.Drawing.Point(3, 59);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 30);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(370, 59);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(80, 30);
            this.btnGuardar.TabIndex = 34;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(284, 59);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 30);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(89, 59);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 30);
            this.btnEliminar.TabIndex = 29;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lSubPrecio
            // 
            this.lSubPrecio.AutoSize = true;
            this.lSubPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubPrecio.Location = new System.Drawing.Point(377, 8);
            this.lSubPrecio.Name = "lSubPrecio";
            this.lSubPrecio.Size = new System.Drawing.Size(54, 25);
            this.lSubPrecio.TabIndex = 32;
            this.lSubPrecio.Text = "0.00";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(109, 7);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 26);
            this.txtCantidad.TabIndex = 28;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(271, 6);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(73, 25);
            this.lPrecio.TabIndex = 31;
            this.lPrecio.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 29;
            this.label8.Text = "Cantidad";
            // 
            // dgvVentas
            // 
            this.dgvVentas.AllowUserToResizeColumns = false;
            this.dgvVentas.AllowUserToResizeRows = false;
            this.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(201)))));
            this.dgvVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvVentas.Location = new System.Drawing.Point(0, 0);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(453, 229);
            this.dgvVentas.TabIndex = 20;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(12, 109);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 8;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(279, 109);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 9;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Inicio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(448, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Fin";
            // 
            // GestionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionFactura";
            this.Text = "GestionFactura";
            this.Load += new System.EventHandler(this.GestionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pDatosCliente.ResumeLayout(false);
            this.pDatosCliente.PerformLayout();
            this.pModificarVenta.ResumeLayout(false);
            this.pModificarVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Panel pModificarVenta;
        private System.Windows.Forms.Label lSubPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pDatosCliente;
        private System.Windows.Forms.Label lCedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
    }
}