using DAL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyectodeaula
{
    public partial class ReporteTopCliente : Form
    {
        private ClienteService clienteService;
        private List<ClienteTopDto> clientesTopDtos;

        public ReporteTopCliente()
        {
            InitializeComponent();
        }

        private void ReporteTopCliente_Load(object sender, EventArgs e)
        {
            clienteService = new ClienteService();
            dtpInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFin.Value = DateTime.Now;

            dtpFin.MaxDate = DateTime.Now;
            dtpInicio.MaxDate = DateTime.Now;

            CargarDatosEnChart();
        }

        private async void CargarDatosEnChart()
        {
            clientesTopDtos = await clienteService.GetTop10Clientes(dtpInicio.Value, dtpFin.Value);
            chtTopClientes.Series[0].Points.Clear();

            foreach (var clienteTopDto in clientesTopDtos)
            {
                var dataPoint = new DataPoint();
                dataPoint.SetValueXY(clienteTopDto.Nombre, clienteTopDto.TotalFacturado);
                chtTopClientes.Series[0].Points.Add(dataPoint);
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
