namespace Design_Patterns
{
    public class AppleFactory : AbstractFactory
    {
        public override Laptop ProduceLaptp()
        {
            return new Mac();
        }

        public override Phone ProducePhone()
        {
            return new IPhone();
        }
    }
}