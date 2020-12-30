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
        public DateTime FlightDate;

       /*
        * 
        public bool CanBeCancelledBy(Customer customer)
        {
            if (customer.IsVip)
                return true;

            if (OrderBy == customer)
                return true;

            return false;
        }

        *///------------------------------------------------------------
  
        public bool CanBeOrderedBy(Customer customer)
        {
            //define flight time
            var defaultDateTime = new DateTime(2021, 5, 1);

            if (customer.Age < 18)
                return false;
            if (FlightDate >= defaultDateTime)
                return false;


            return true;
        }

      

    }
}
