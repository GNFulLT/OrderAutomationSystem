using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace OrderAutomationSystem
{
   public static class Email
    {
          public static bool sendVerify(string Email,string verifyCode)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.live.com");
                NetworkCredential cred = new NetworkCredential("shoppyBot@outlook.com", "shoppy123");
                MailAddress to = new MailAddress(Email);
                MailAddress from = new MailAddress("shoppyBot@outlook.com");
                MailMessage Msg = new MailMessage();
                
                Msg.To.Add(to);
                Msg.From = from;
                Msg.Subject = "Verify Code";
                Msg.Body = verifyCode;      
                Msg.IsBodyHtml = true;
                client.Port = 587;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);
                return true;
               
            }
            catch(Exception e)
            {
                Exception a = e;
                return false;
            }
        }
        internal static bool sendOrder(string Email,Order order)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.live.com");
                NetworkCredential cred = new NetworkCredential("shoppyBot@outlook.com", "shoppy123");
                MailAddress to = new MailAddress(Email);
                MailAddress from = new MailAddress("shoppyBot@outlook.com");
                MailMessage Msg = new MailMessage();
                Msg.To.Add(to);
                Msg.From = from;
                Msg.Subject = "Your order has been received successfully";
                Msg.Body = $"Date         : {order.Date}\n" +
                           $"State        : {order.State}\n" +
                           $"Total Amount : {order.Details.TotalAmount}\n" +
                           $"           Had been bought  : ";
                foreach(var item in order.Details.Items)
                {
                    Msg.Body += $"{item.Name}         {item.Quantity}\n";
                }
                client.Port = 587;
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(Msg);

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
