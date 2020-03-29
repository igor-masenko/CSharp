namespace Factory
{
    /// <summary>
    /// Контрагент осуществляющий доставку по воздуху
    /// </summary>
    class AirContractor : FactoryContracor
    {
        public AirContractor(string name) : base(name) { }

        public override Delivery Create()
        {
            return new AirDelivery();
        }
    }
}
