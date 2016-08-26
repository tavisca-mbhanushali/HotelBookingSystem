using System;

using HotelBooking.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking.BussinessLogic;

namespace HotelData.BusinessLogic.TestSuite
{
    [TestClass]
    public class CustomerBussinesLogic
    {
        [TestMethod]
        public void SelectCustomers()
        {
            SelectCustomer selectCustomer = new SelectCustomer();
            var customerasda = selectCustomer.GetustomerByFirstName("Mayuresh");
        }
    }
}


