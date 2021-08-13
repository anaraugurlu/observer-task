using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_task
{
    public class Store
    {
        public List<ICustomer> Customers { get; set; }
        public void Notify()
        {
            foreach (var customer in Customers)
            {
                customer.GetMessage();
            }
        }
    }
}
