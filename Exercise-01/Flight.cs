using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
   public class Flight
    {
        public Customer OrderBy { get; set; }
        public DateTime CreationDate = DateTime.Now;


        public bool CanBeCancelledBy(Customer customer)
        {
            if (customer.IsVip)
                return true;

            if (OrderBy == customer)
                return true;

            return false;
        }

    }
}
