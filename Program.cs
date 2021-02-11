using Design_Patterns.FactoryMethod;
using Design_Patterns.SimpleFactory;
using System;

namespace Design_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Design Pattern!");

            SingletonSample.Run();

            SimpleFactorySample.Run();

            FactoryMethodSample.Run();

            AbstractFactorySample.Run();

            Console.ReadLine();
        }
    }
}
