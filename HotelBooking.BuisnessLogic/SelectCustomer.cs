using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelData.Entity;
using HotelBooking.Data;

namespace HotelBooking.BussinessLogic
{
    public class SelectCustomer
    {
        public Customer GetustomerByFirstName(string firstName)
        {
            CustomerDBImpl customerDBImpl = new CustomerDBImpl();
            return TranslateCustomer.PaserCustomer(customerDBImpl.SelectCusotmer(firstName));
        }
    }
}
