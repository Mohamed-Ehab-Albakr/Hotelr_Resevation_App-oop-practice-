using System;
using System.Collections.Generic;
using System.Text;

namespace HotelReservation.core
{
   public abstract  class Reservation
    {
        Reservation(Customer c)
        {
            customer = c; // refrence to the customer 
        }



        Customer customer;
        Room room;
        double Price;
        DateTime Date;







    }
}
