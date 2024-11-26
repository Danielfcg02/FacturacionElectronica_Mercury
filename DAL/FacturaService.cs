using ENTITY;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

public class FacturaService
{
    private readonly FacturaRepository _facturaRepository;
    private readonly VentaRepository _ventaRepository;

    public FacturaService()
    {
        _ventaRepository = new VentaRepository(new BLL.OracleDbContext());
        _facturaRepository = new FacturaRepository(new BLL.OracleDbContext(), _ventaRepository);
    }

    public async Task<List<Factura>> GetFacturasByFecha(DateTime fechaInicio, DateTime fechaFin)
    {
        var todasLasFacturas = await _facturaRepository.GetFacturasByFecha(fechaInicio, fechaFin);

        if (Session.user.Role == "EMPLEADO")
        {
            return todasLasFacturas
                .Where(f => f.User.Cedula == Session.user.Cedula) 
                .ToList();
        }

        return todasLasFacturas;
    }


    public async Task<List<Venta>> GetVentasByFacturaId(string facturaId)
    {
        return await _ventaRepository.GetVentasByFacturaId(facturaId);
    }


    // Agregar una nueva factura
    public async Task<string> AddFactura(Factura factura)
    {

        await _facturaRepository.GuardarFactura(factura);

        string documentosPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        string facturasFolder = Path.Combine(documentosPath, "Facturas");

        // Crear la carpeta "Facturas" si no existe
        if (!Directory.Exists(facturasFolder))
        {
            Directory.CreateDirectory(facturasFolder);
        }

        string nombreArchivo = $"factura-{factura.Id}.pdf";
        // string nombreArchivo = $"factura-{factura.Id}.xml";

        string filePath = Path.Combine(facturasFolder, nombreArchivo);


        DocumentService docunmentService = new DocumentService();
        docunmentService.CreatePdfFile(factura, filePath);
        //xmlService.CreateXmlFile(factura, filePath);

        EmailService emailService = new EmailService();
        string resultado = emailService.SendEmail(factura.Cliente, filePath);

        return resultado;
    }

    public async Task AddVenta(Venta venta, string facturaId)
    {
        await _ventaRepository.AddVenta(venta, facturaId);
    }

    // Actualizar una factura existente
    public async Task ActualizarVentaFacturas(List<Venta> ventas)
    {
        foreach (var venta in ventas)
        {
            await _ventaRepository.UpdateVenta(venta);
        }
    }


    // Eliminar una factura
    public async Task DeleteFactura(int id)
    {
        await _facturaRepository.DeleteFactura(id);
    }

    //reportes
    public async Task<List<VentasMensualesDto>> ObtenerVentasMensuales(DateTime fechaInicio, DateTime fechaFin)
    {
        List<Factura> facturas = await GetFacturasByFecha(fechaInicio, fechaFin);
        return facturas
            .GroupBy(f => new { f.FechaCreacion.Year, f.FechaCreacion.Month })
            .Select(g => new VentasMensualesDto
            {
                Mes = new DateTime(g.Key.Year, g.Key.Month, 1),
                TotalVentas = g.Sum(f => f.Total)
            })
            .ToList();
    }

    
}
