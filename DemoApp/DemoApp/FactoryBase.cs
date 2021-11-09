namespace DemoApp
{
    public class FactoryBase
    {
        private readonly RawMaterialSupplier _rawMaterialSupplier;
        private readonly LogisticSystem _logisticSystem;

        public FactoryBase(RawMaterialSupplier rawMaterialSupplier, LogisticSystem logisticSystem)
        {
            _rawMaterialSupplier = rawMaterialSupplier;
            _logisticSystem = logisticSystem;
        }

        public bool CheckFactoryStatus()
        {
            var isOperating = true;

            return isOperating;
        }
    }
}