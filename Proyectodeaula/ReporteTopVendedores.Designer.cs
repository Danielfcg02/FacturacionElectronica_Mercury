namespace Proyectodeaula
{
    partial class ReporteTopVendedores
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chtTopVendedores = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chtTopVendedores)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(780, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Inicio";
            // 
            // dtpFin
            // 
            this.dtpFin.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFin.Location = new System.Drawing.Point(620, 89);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 21;
            this.dtpFin.ValueChanged += new System.EventHandler(this.dtpFin_ValueChanged);
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicio.Location = new System.Drawing.Point(134, 89);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 20;
            this.dtpInicio.ValueChanged += new System.EventHandler(this.dtpInicio_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Top 10 Vendedores";
            // 
            // chtTopVendedores
            // 
            chartArea1.Name = "ChartArea1";
            this.chtTopVendedores.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtTopVendedores.Legends.Add(legend1);
            this.chtTopVendedores.Location = new System.Drawing.Point(134, 115);
            this.chtTopVendedores.Name = "chtTopVendedores";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtTopVendedores.Series.Add(series1);
            this.chtTopVendedores.Size = new System.Drawing.Size(686, 445);
            this.chtTopVendedores.TabIndex = 18;
            this.chtTopVendedores.Text = "chart1";
            // 
            // ReporteTopVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(235)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chtTopVendedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteTopVendedores";
            this.Text = "ReporteTopVendedores";
            this.Load += new System.EventHandler(this.ReporteTopVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chtTopVendedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtTopVendedores;
    }
}