using System;

namespace Factory
{
    /// <summary>
    /// Доствка по воздуху
    /// </summary>
    class AirDelivery : Delivery
    {
        public AirDelivery()
        {
            Console.WriteLine("Осуществляется доставка по воздуху");
        }
    }
}
