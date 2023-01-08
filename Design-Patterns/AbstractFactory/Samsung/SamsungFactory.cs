namespace Design_Patterns
{
    public class SamsungFactory : AbstractFactory
    {
        public override Laptop ProduceLaptp()
        {
            return new SamsungLaptop();
        }

        public override Phone ProducePhone()
        {
            return new GalaxyPhone();
        }
    }
}