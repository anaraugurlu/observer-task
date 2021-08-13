using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace observer_task
{
    class Email
    {
        
        public static void Send(string text)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("e4105651@gmail.com","anara2003"),
                EnableSsl = true,
            };

            smtpClient.Send("e4105651@gmail.com",text, "Store", "the product was recorded");
        }
    }
}
