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
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyectodeaula
{
    public partial class ReporteVentasMensuales : Form
    {
        private FacturaService facturaService;

        private List<VentasMensualesDto> ventasMensualesDtos;

        public ReporteVentasMensuales()
        {
            InitializeComponent();
        }

        private void ReporteVentasMensuales_Load(object sender, EventArgs e)
        {
            facturaService = new FacturaService();
            dtpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month-1 , 1);

            dtpFin.Value = DateTime.Now;

            dtpFin.MaxDate = DateTime.Now;
            dtpInicio.MaxDate = DateTime.Now;

            CargarDatosEnChart();
        }

        private async void CargarDatosEnChart()
        {
            ventasMensualesDtos = await facturaService.ObtenerVentasMensuales(dtpInicio.Value, dtpFin.Value);
            // Limpiar el chart
            chtVentasMensuales.Series[0].Points.Clear();

            foreach (var ventaMensualdto in ventasMensualesDtos)
            {
                var dataPoint = new DataPoint();
                dataPoint.SetValueXY(ventaMensualdto.Mes.ToString("MMMM"), ventaMensualdto.TotalVentas);
                chtVentasMensuales.Series[0].Points.Add(dataPoint);
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            CargarDatosEnChart();
        }

        private void dtpFin_ValueChanged(object sender, EventArgs e)
        {
            CargarDatosEnChart();
        }
    }
}
