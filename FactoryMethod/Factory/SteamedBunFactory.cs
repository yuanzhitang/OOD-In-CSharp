namespace Design_Patterns.FactoryMethod
{
	public class SteamedBunFactory : Factory
	{
		protected override Machine CreateMachine()
		{
			return new SteamedBunMachine();
		}
	}
}
