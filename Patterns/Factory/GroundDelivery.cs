using System;

namespace Factory
{
    /// <summary>
    /// Доставка по воздуху
    /// </summary>
    class GroundDelivery : Delivery
    {
        public GroundDelivery()
        {
            Console.WriteLine("Осуществляется доставка по земле");
        }
    }
}
