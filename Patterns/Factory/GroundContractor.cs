namespace Factory
{
    /// <summary>
    /// Контрагент осуществляющий доставку по земле
    /// </summary>
    class GroundContractor : FactoryContracor
    {
        public GroundContractor(string name) : base(name) { }

        public override Delivery Create()
        {
            return new GroundDelivery();
        }
    }
}
