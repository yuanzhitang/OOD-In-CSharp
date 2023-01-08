using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod
{
	class FactoryMethodSample
	{
		public static void Run()
		{
			Console.WriteLine("\tFactoryMethod\t");

			var noodlesFactory = new NoodlesFactory();
			var noodles = noodlesFactory.Produce();

			Console.WriteLine($"{nameof(noodles)} is {noodles.GetType()}");

			var steamedBunFactory = new SteamedBunFactory();
			var steamedBun = steamedBunFactory.Produce();
			Console.WriteLine($"{nameof(steamedBun)} is {steamedBun.GetType()}");
		}
	}
}
