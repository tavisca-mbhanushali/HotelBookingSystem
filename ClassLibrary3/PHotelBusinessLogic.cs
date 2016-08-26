using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PHotelInfoPojoData.Entity;
using HotelRegistration2.Data;
using HotelBooking.Data;

namespace HotelBooking.BussinessLogic
{
    public class PSelectHotel
    {
        public static HotelInfo GetHotelInfoByFirstName(string HotelName)
        {
            HotelDBImpl hotelDBImpl = new HotelDBImpl();
            return TranslateHotelInfo.PaserHotelInfo(hotelDBImpl.SelectHotel(HotelName));

           
        }
    }
}