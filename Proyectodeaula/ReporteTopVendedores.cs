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
    public partial class ReporteTopVendedores : Form
    {
        private UsuarioService userService;
        private List<VendedorDto> topVendedores;

        public ReporteTopVendedores()
        {
            InitializeComponent();
            userService = new UsuarioService();
        }

        private async void ReporteTopVendedores_Load(object sender, EventArgs e)
        {
            dtpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFin.Value = DateTime.Now;
            dtpFin.MaxDate = DateTime.Now;
            dtpInicio.MaxDate = DateTime.Now;

            await CargarDatosEnChart();
        }

        private async Task CargarDatosEnChart()
        {
            topVendedores = await userService.ObtenerTop10Vendedores(dtpInicio.Value, dtpFin.Value);

            chtTopVendedores.Series[0].Points.Clear();

            foreach (var vendedor in topVendedores)
            {
                chtTopVendedores.Series[0].Points.AddXY(vendedor.Nombre, vendedor.TotalFacturado);
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
