using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace observer_task
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Email2 { get; set; }
        void GetMessage();
        
    }
}
