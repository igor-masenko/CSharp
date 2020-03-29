using System;

namespace Factory
{
    /// <summary>
    /// Доставка по воде
    /// </summary>
    class Shipping : Delivery
    {
        public Shipping()
        {
            Console.WriteLine("Осуществляется доставка по воде");
        }
    }
}
