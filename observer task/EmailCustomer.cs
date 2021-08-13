using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_task
{
   public class EmailCustomer : ICustomer
    {
        public string Name { get; set; }
        public string Email2 { get ; set ; }

        public void GetMessage()
        {
            Email.Send (Email2 );
            

        }


    }
}
