using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using PHotelBooking.BuisnessLogic.HotelSearch;
using HotelBooking.BussinessLogic;
using PHotelInfoPojoData.Entity;

namespace PHotelData.BuisnessLogic.TestSuite
{
    public class HotelInfoBusinessLogic
    {

        PSelectHotel selectHotelInfo = new PSelectHotel();
        HotelInfo HotelInfodata = PSelectHotel.GetHotelInfoByFirstName("Mayuresh");


    }
}




