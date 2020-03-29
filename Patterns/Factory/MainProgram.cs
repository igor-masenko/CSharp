namespace Factory
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            FactoryContracor cntr;

            #region Список контрагентов
            string cntrButterfly = "Бабочка";
            string cntrWaydo = "Waydo";
            string cntrShark = "Акула";
            string cntrTitanic = "Титаник";
            string cntrICLogistic = "АйСи Логистик";
            #endregion

            cntr = new ShippingContractor(cntrTitanic);
            cntr.Create();

            cntr = new AirContractor(cntrButterfly);
            cntr.Create();

            cntr = new GroundContractor(cntrICLogistic);
            cntr.Create();

            cntr = new ShippingContractor(cntrICLogistic);
            cntr.Create();

            cntr = new AirContractor(cntrWaydo);
            cntr.Create();

            cntr = new ShippingContractor(cntrWaydo);
            cntr.Create();

            cntr = new ShippingContractor(cntrShark);
            cntr.Create();

        }
    }
}
