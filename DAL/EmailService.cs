using ENTITY;
using System;
using System.Net;
using System.Net.Mail;

public class EmailService
{
    public string SendEmail(Cliente cliente, string attachmentPath)
    {
        MailMessage mCorreo = new MailMessage();

        string myEmail = "edaviddaza@unicesar.edu.co";
        string myPassword = "cfronimormjjrivd";
        string myAlias = "Admin";

        mCorreo.From = new MailAddress(myEmail, myAlias, System.Text.Encoding.UTF8);
        mCorreo.To.Add(cliente.Correo);
        mCorreo.Subject = "Gracias por tu compra!";

        string body = $"<h1>The New Vintage!</h1>" +
                      $"<p>Estimado {cliente.Nombre},</p>" +
                      "<p>¡Gracias por tu compra! Apreciamos tu confianza en nosotros.</p>" +
                      "<p>Si tienes alguna pregunta, no dudes en contactarnos.</p>" +
                      "<p>Saludos cordiales,<br />Tu equipo de The New Vintage</p>";

        mCorreo.Body = body;
        mCorreo.IsBodyHtml = true;
        mCorreo.Priority = MailPriority.High;

        if (!string.IsNullOrEmpty(attachmentPath))
        {
            mCorreo.Attachments.Add(new Attachment(attachmentPath));
        }

        try
        {
            SmtpClient smtp = new SmtpClient
            {
                UseDefaultCredentials = false,
                Port = 587,
                Host = "smtp.gmail.com",
                Credentials = new NetworkCredential(myEmail, myPassword),
                EnableSsl = true
            };

            smtp.Send(mCorreo);
            return "Correo enviado exitosamente.";
        }
        catch (Exception e)
        {
            return "Error al enviar el correo: " + e.Message;
        }
    }
}
