using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_01
{
   public class Flight
    {
        Customer OrderBy { get; set; }
        DateTime CreationDate = DateTime.Now;

        public bool CanBeCancelledBy(Customer customer)
        {
            bool result;

            if (customer.IsVip)
                result = true;

            else if (OrderBy == customer)
                result = true;

            else
                result = false;


            return result;
        }

    }
}
