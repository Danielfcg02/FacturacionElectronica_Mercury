using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using ENTITY;

public class InvoicePrinter
{
    private Factura _factura;
    private PrintDocument _printDocument;

    public InvoicePrinter(Factura factura)
    {
        _factura = factura;
        _printDocument = new PrintDocument();
        _printDocument.PrintPage += new PrintPageEventHandler(PrintPageHandler);
    }

    public void Print()
    {
        using (PrintDialog printDialog = new PrintDialog())
        {
            printDialog.Document = _printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _printDocument.Print();
            }
        }
    }

    private void PrintPageHandler(object sender, PrintPageEventArgs e)
    {
        Font fontRegular = new Font("Calibri", 10);
        Font fontBold = new Font("Calibri", 10, FontStyle.Bold);
        int leftMargin = 10;
        int yPosition = 20; 

        
        e.Graphics.DrawString("Factura", fontBold, Brushes.Black, leftMargin, yPosition);
        yPosition += 20;

        e.Graphics.DrawString($"Cajero: {_factura.User.Name}", fontRegular, Brushes.Black, leftMargin, yPosition);
        yPosition += 20;

        e.Graphics.DrawString($"Cliente: {_factura.Cliente.Nombre}", fontRegular, Brushes.Black, leftMargin, yPosition);
        yPosition += 20;
        e.Graphics.DrawString($"Fecha: {_factura.FechaCreacion.ToShortDateString()}", fontRegular, Brushes.Black, leftMargin, yPosition);
        yPosition += 20;

        e.Graphics.DrawString("Cant.", fontBold, Brushes.Black, leftMargin, yPosition);
        e.Graphics.DrawString("Descripción", fontBold, Brushes.Black, leftMargin + 50, yPosition);
        e.Graphics.DrawString("Valor", fontBold, Brushes.Black, leftMargin + 200, yPosition);
        e.Graphics.DrawString("Total", fontBold, Brushes.Black, leftMargin + 300, yPosition);
        yPosition += 20;

        e.Graphics.DrawString("--------------------------------------------------", fontRegular, Brushes.Black, leftMargin, yPosition);
        yPosition += 20;

        foreach (var venta in _factura.Ventas)
        {
            e.Graphics.DrawString(venta.Quantity.ToString(), fontRegular, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString(venta.Producto.Nombre, fontRegular, Brushes.Black, leftMargin + 50, yPosition);
            e.Graphics.DrawString(venta.Producto.Precio.ToString("C"), fontRegular, Brushes.Black, leftMargin + 200, yPosition);
            e.Graphics.DrawString(venta.Subtotal.ToString("C"), fontRegular, Brushes.Black, leftMargin + 300, yPosition);
            yPosition += 20;
        }

        e.Graphics.DrawString("--------------------------------------------------", fontRegular, Brushes.Black, leftMargin, yPosition);
        yPosition += 20;

        e.Graphics.DrawString($"Total: {_factura.Total.ToString("C")}", fontBold, Brushes.Black, leftMargin + 300, yPosition);
    }
}
