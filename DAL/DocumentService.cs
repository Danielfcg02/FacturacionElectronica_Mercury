using ENTITY;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

public class DocumentService
{
    public void CreateXmlFile(Factura factura, string filePath)
    {
        XDocument doc = new XDocument(
            new XElement("Factura",
                new XElement("Id", factura.Id),
                new XElement("Usuario",
                    new XElement("Cedula", factura.User.Cedula),
                    new XElement("Nombre", factura.User.Name),
                    new XElement("Email", factura.User.Email)
                ),
                new XElement("Cliente",
                    new XElement("Cedula", factura.Cliente.Cedula),
                    new XElement("Nombre", factura.Cliente.Nombre),
                    new XElement("Correo", factura.Cliente.Correo)
                ),
                new XElement("Total", factura.Total),
                new XElement("FechaCreacion", factura.FechaCreacion),
                new XElement("Ventas",
                    from venta in factura.Ventas
                    select new XElement("Venta",
                        new XElement("Producto",
                            new XElement("Id", venta.Producto.Id),
                            new XElement("Nombre", venta.Producto.Nombre),
                            new XElement("Precio", venta.Producto.Precio),
                            new XElement("Cantidad", venta.Quantity),
                            new XElement("Subtotal", venta.Subtotal)
                        )
                    )
                )
            )
        );

        doc.Save(filePath);
    }

    public void CreatePdfFile(Factura factura, string filePath)
    {
        double totalFactura = factura.Ventas.Sum(venta => venta.Subtotal);

        Document doc = new Document();
        PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
        doc.Open();

        var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
        doc.Add(new Paragraph("Factura", titleFont));
        doc.Add(new Paragraph("Fecha de Creación: " + factura.FechaCreacion + "\n\n"));

        PdfPTable infoTable = new PdfPTable(2) { WidthPercentage = 100 };
        infoTable.AddCell("Usuario");
        infoTable.AddCell("Cliente");

        infoTable.AddCell(new Phrase("Cedula: " + factura.User.Cedula));
        infoTable.AddCell(new Phrase("Cedula: " + factura.Cliente.Cedula));
        infoTable.AddCell(new Phrase("Nombre: " + factura.User.Name));
        infoTable.AddCell(new Phrase("Nombre: " + factura.Cliente.Nombre));
        infoTable.AddCell(new Phrase("Email: " + factura.User.Email));
        infoTable.AddCell(new Phrase("Correo: " + factura.Cliente.Correo));

        doc.Add(infoTable);

        doc.Add(new Paragraph("\nVentas\n\n"));

        PdfPTable ventasTable = new PdfPTable(5) { WidthPercentage = 100 };
        ventasTable.AddCell("Producto ID");
        ventasTable.AddCell("Nombre");
        ventasTable.AddCell("Precio");
        ventasTable.AddCell("Cantidad");
        ventasTable.AddCell("Subtotal");

        foreach (var venta in factura.Ventas)
        {
            ventasTable.AddCell(venta.Producto.Id.ToString());
            ventasTable.AddCell(venta.Producto.Nombre);
            ventasTable.AddCell(venta.Producto.Precio.ToString("C"));
            ventasTable.AddCell(venta.Quantity.ToString());
            ventasTable.AddCell(venta.Subtotal.ToString("C"));
        }

        doc.Add(ventasTable);

        doc.Add(new Paragraph("\nTotal: " + totalFactura.ToString("C"), titleFont));

        doc.Close();
    }

}
