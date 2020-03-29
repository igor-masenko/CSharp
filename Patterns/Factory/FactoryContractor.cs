namespace Factory
{
    /// <summary>
    /// Абстрактный класс Контрагента. Выполняют доставку груза. 
    /// </summary>
    /// <param name="Наименование контрагента"/>
    abstract class FactoryContracor
    {
        private readonly string name;

        /// <summary>
        /// Наименование контрагента
        /// </summary>
        public string Name { get; set; }

        public FactoryContracor(string name)
        {
            Name = name;
            this.name = name;
        }

        /// <summary>
        /// Создание класса FactoryContracor по конкретному виду доставки
        /// </summary>
        /// <returns></returns>
        abstract public Delivery Create();
    }
}
