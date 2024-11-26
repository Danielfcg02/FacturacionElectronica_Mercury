namespace Proyectodeaula
{
    partial class CrearFactura
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pDatosCliente = new System.Windows.Forms.Panel();
            this.lCorreo = new System.Windows.Forms.Label();
            this.lTelefono = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCrearCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lSubPrecio = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvVentas = new System.Windows.Forms.DataGridView();
            this.pCliente = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pDatosCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).BeginInit();
            this.pCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(422, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Crear factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Buscar producto";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(12, 103);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(465, 26);
            this.txtBuscarProducto.TabIndex = 6;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(239)))), ((int)(((byte)(201)))));
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 150);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(465, 423);
            this.dgvProductos.TabIndex = 5;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Buscar cliente";
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCliente.Location = new System.Drawing.Point(7, 32);
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(300, 26);
            this.txtBuscarCliente.TabIndex = 8;
            this.txtBuscarCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre";
            // 
            // pDatosCliente
            // 
            this.pDatosCliente.Controls.Add(this.lCorreo);
            this.pDatosCliente.Controls.Add(this.lTelefono);
            this.pDatosCliente.Controls.Add(this.lNombre);
            this.pDatosCliente.Controls.Add(this.label6);
            this.pDatosCliente.Controls.Add(this.label5);
            this.pDatosCliente.Controls.Add(this.label4);
            this.pDatosCliente.Location = new System.Drawing.Point(8, 64);
            this.pDatosCliente.Name = "pDatosCliente";
            this.pDatosCliente.Size = new System.Drawing.Size(300, 100);
            this.pDatosCliente.TabIndex = 11;
            this.pDatosCliente.Visible = false;
            // 
            // lCorreo
            // 
            this.lCorreo.AutoSize = true;
            this.lCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCorreo.Location = new System.Drawing.Point(143, 69);
            this.lCorreo.Name = "lCorreo";
            this.lCorreo.Size = new System.Drawing.Size(57, 20);
            this.lCorreo.TabIndex = 15;
            this.lCorreo.Text = "Correo";
            // 
            // lTelefono
            // 
            this.lTelefono.AutoSize = true;
            this.lTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTelefono.Location = new System.Drawing.Point(143, 39);
            this.lTelefono.Name = "lTelefono";
            this.lTelefono.Size = new System.Drawing.Size(71, 20);
            this.lTelefono.TabIndex = 14;
            this.lTelefono.Text = "Telefono";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(143, 9);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(65, 20);
            this.lNombre.TabIndex = 13;
            this.lNombre.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Correo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // btnCrearCliente
            // 
            this.btnCrearCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.btnCrearCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearCliente.Location = new System.Drawing.Point(7, 64);
            this.btnCrearCliente.Name = "btnCrearCliente";
            this.btnCrearCliente.Size = new System.Drawing.Size(300, 30);
            this.btnCrearCliente.TabIndex = 16;
            this.btnCrearCliente.Text = "Crear cliente";
            this.btnCrearCliente.UseVisualStyleBackColor = false;
            this.btnCrearCliente.Visible = false;
            this.btnCrearCliente.Click += new System.EventHandler(this.btnCrearCliente_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.lTotal);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.lSubPrecio);
            this.panel1.Controls.Add(this.lPrecio);
            this.panel1.Controls.Add(this.btnAgregarVenta);
            this.panel1.Controls.Add(this.txtCantidad);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.dgvVentas);
            this.panel1.Location = new System.Drawing.Point(483, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 323);
            this.panel1.TabIndex = 17;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(311, 294);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(49, 20);
            this.lbTotal.TabIndex = 30;
            this.lbTotal.Text = "Total";
            // 
            // lTotal
            // 
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(395, 290);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(54, 25);
            this.lTotal.TabIndex = 29;
            this.lTotal.Text = "0.00";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Gray;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminar.Location = new System.Drawing.Point(7, 290);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 30);
            this.btnEliminar.TabIndex = 28;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lSubPrecio
            // 
            this.lSubPrecio.AutoSize = true;
            this.lSubPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubPrecio.Location = new System.Drawing.Point(259, 240);
            this.lSubPrecio.Name = "lSubPrecio";
            this.lSubPrecio.Size = new System.Drawing.Size(54, 25);
            this.lSubPrecio.TabIndex = 27;
            this.lSubPrecio.Text = "0.00";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(180, 239);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(73, 25);
            this.lPrecio.TabIndex = 26;
            this.lPrecio.Text = "Precio";
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.btnAgregarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVenta.Enabled = false;
            this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVenta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarVenta.Location = new System.Drawing.Point(349, 235);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(100, 30);
            this.btnAgregarVenta.TabIndex = 25;
            this.btnAgregarVenta.Text = "AgregarVenta";
            this.btnAgregarVenta.UseVisualStyleBackColor = false;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(108, 238);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(66, 26);
            this.txtCantidad.TabIndex = 23;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 25);
            this.label8.TabIndex = 24;
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
            this.dgvVentas.Location = new System.Drawing.Point(8, 3);
            this.dgvVentas.MultiSelect = false;
            this.dgvVentas.Name = "dgvVentas";
            this.dgvVentas.ReadOnly = true;
            this.dgvVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentas.Size = new System.Drawing.Size(441, 229);
            this.dgvVentas.TabIndex = 19;
            this.dgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVentas_CellClick);
            // 
            // pCliente
            // 
            this.pCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCliente.Controls.Add(this.label3);
            this.pCliente.Controls.Add(this.btnCrearCliente);
            this.pCliente.Controls.Add(this.pDatosCliente);
            this.pCliente.Controls.Add(this.txtBuscarCliente);
            this.pCliente.Location = new System.Drawing.Point(490, 400);
            this.pCliente.Name = "pCliente";
            this.pCliente.Size = new System.Drawing.Size(315, 173);
            this.pCliente.TabIndex = 18;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(152)))), ((int)(((byte)(74)))));
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.Location = new System.Drawing.Point(827, 473);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 30);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gray;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(827, 529);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 30);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CrearFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(950, 584);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CrearFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearFactura";
            this.Load += new System.EventHandler(this.CrearFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pDatosCliente.ResumeLayout(false);
            this.pDatosCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentas)).EndInit();
            this.pCliente.ResumeLayout(false);
            this.pCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pDatosCliente;
        private System.Windows.Forms.Label lCorreo;
        private System.Windows.Forms.Label lTelefono;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCrearCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pCliente;
        private System.Windows.Forms.DataGridView dgvVentas;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lSubPrecio;
        private System.Windows.Forms.Label lPrecio;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Button btnCancelar;
    }
}