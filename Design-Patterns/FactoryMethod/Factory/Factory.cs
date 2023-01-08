namespace Design_Patterns.FactoryMethod
{
	public abstract class Factory
	{
		protected abstract Machine CreateMachine();

		public Product Produce()
		{
			var machine = CreateMachine();
			return machine.Process();
		}
	}
}
