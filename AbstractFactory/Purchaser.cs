using System;

namespace Design_Patterns
{
    public class Purchaser
    {
        private AbstractFactory _factory;
        public Purchaser(AbstractFactory factory)
        {
            _factory = factory;
        }

        public void Buy()
        {
            var phone = _factory.ProducePhone();
            var laptop = _factory.ProduceLaptp();

            Console.WriteLine($"ProductInfo:{phone.Detail},{laptop.Detail}");
        }
    }
}