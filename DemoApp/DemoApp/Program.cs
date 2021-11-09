using System;

namespace DemoApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var honeyFactory = new HoneyFactory(new RawMaterialSupplier(), new LogisticSystem());
            //var honeyFactory = new HoneyFactory(); // uncomment this to reproduce the error
            var operatingMessage = honeyFactory.CheckFactoryStatus() ? "Yes" : "No";

            Console.WriteLine($"Is honey factory operating? { operatingMessage}");
        }
    }
}