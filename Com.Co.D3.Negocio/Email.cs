using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace Com.Co.D3.Negocio
{
    public class Email
    {
        private SmtpClient smtp;

        public Email()
        {
            smtp = new SmtpClient();
            smtp.EnableSsl = false;
        }

        public void EnvioCorreoCambioEstadoPedidos()
        {
            try
            {
                if (smtp != null)
                {
                    MailMessage email = new MailMessage();
                    email.To.Add(new MailAddress("nadyaortiz@gmail.com"));
                    email.From = new MailAddress("salas_13@hotmail.com");
                    email.Subject = "Asunto aceptados - " + DateTime.Now.ToString("dd / MM / yyyy hh:mm:ss");
                    email.Body = "Cualquier contenido en <b>HTML</b> para enviarlo por correo electrónico.";
                    email.IsBodyHtml = true;
                    email.Priority = MailPriority.Normal;

                    smtp.Send(email);
                    email.Dispose();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
