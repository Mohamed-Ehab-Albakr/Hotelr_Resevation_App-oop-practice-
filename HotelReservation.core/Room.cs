using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.core
{
     abstract class  Room
    {
        #region feilds
        private int system_id;
        public int room_number;
        internal double price;
        public int number_of_days_reserved;


        #endregion

        #region methods
        abstract internal bool IsAvillable();
        abstract internal void CheckIn();
        abstract internal void CheckOut();
        abstract internal void IsCleaned(); 
        #endregion





    }
}
