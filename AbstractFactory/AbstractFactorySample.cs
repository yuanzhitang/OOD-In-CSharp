using System;

namespace Design_Patterns
{
    class AbstractFactorySample
    {
        public static void Run()
        {
            Console.WriteLine("\tAbstractFactory\t");

            var appleFactory = new AppleFactory();

            var purchaser = new Purchaser(appleFactory);
            purchaser.Buy();


            var sumsungFactory = new SamsungFactory();
            purchaser = new Purchaser(sumsungFactory);
            purchaser.Buy();
        }
    }
}