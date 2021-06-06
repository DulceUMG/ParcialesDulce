using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;


namespace CHAT_BOT.CLASES
{
    class clsCorreo
    {
        private string EmailOrigen = "coloque su correo";
        private string Contraseña = "coloque su contraseña";

        public string enviar(string abc)
        {
            string mensaje = "";

            try
            {
                clsToken token = new clsToken();
                string tokenalfanumerico = token.GenerarCodigo();

                MailMessage mail = new MailMessage(EmailOrigen, abc, "DulceMazareigos ", "su Token es:" + tokenalfanumerico);
                mail.IsBodyHtml = true;
                mail.Priority = MailPriority.Normal;

                SmtpClient mail2 = new SmtpClient("stmp.gmail.com");
                mail2.EnableSsl = true;
                mail2.UseDefaultCredentials = false;
                mail2.Host = "stmp.gmail.com";
                mail2.Port = 587;
                mail2.Credentials = new System.Net.NetworkCredential(EmailOrigen, Contraseña);

                mail2.Send(mail);
                mail2.Dispose();
                mensaje = "Su correo fué enviado exitosamente";

            }
            catch (Exception)
            {
                mensaje = "Lo siento su correo no fue enviado intente de nuevo";
            }
            return mensaje;






        }



    }
}
