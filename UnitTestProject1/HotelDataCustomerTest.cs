using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelBooking.Data;

namespace UnitTestProject1
{
    [TestClass]
    public class test_1
    {
        [TestMethod]
        public void insert()
        {
            CustomerDBImpl customerdbImple = new CustomerDBImpl();
            customerdbImple.InsertCustomer("Mayurersh", "Bhanushali", "mbhanushali@tavisca.com", "1234567890");

        }
    }
}
