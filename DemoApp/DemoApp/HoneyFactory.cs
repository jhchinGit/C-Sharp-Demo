namespace DemoApp
{
    public class HoneyFactory : FactoryBase
    {
        public HoneyFactory(RawMaterialSupplier rawMaterialSupplier, LogisticSystem logisticSystem) : base(rawMaterialSupplier, logisticSystem)
        {
        }
    }
}