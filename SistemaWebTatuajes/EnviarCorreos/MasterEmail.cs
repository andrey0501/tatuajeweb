using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SistemaWebTatuajes.EnviarCorreos
{
    public class MasterEmail : IMasterEmail
    {

        //METODOS PARA EL SERVICIO DE ENVIAR EMAILS EN CONSULTAS
        public async Task SendEmail(string mensaje, string asunto, List<string> emails)
        {
            var mailMessage = new MailMessage();
            SmtpClient smtpClient = new SmtpClient();
            string senderMail = "reservascr.net@gmail.com";
            string pasword = "roberto123456@";
            smtpClient.Credentials = new NetworkCredential(senderMail, pasword);
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;

            try
            {
                mailMessage.IsBodyHtml = true;
                mailMessage.From = new MailAddress(senderMail);
                foreach (string email in emails) mailMessage.To.Add(email);
                mailMessage.Subject = asunto;
                mailMessage.Body = mensaje;
                mailMessage.Priority = MailPriority.Normal;
                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (Exception) { throw; }
            finally
            {
                smtpClient.Dispose();
                mailMessage.Dispose();
            }
        }


    }
}
