namespace Factory
{
    /// <summary>
    /// Контрагент осуществляющий доставку по воде
    /// </summary>
    class ShippingContractor : FactoryContracor
    {
        public ShippingContractor(string name) : base(name) { }

        public override Delivery Create()
        {
            return new Shipping();
        }
    }
}
