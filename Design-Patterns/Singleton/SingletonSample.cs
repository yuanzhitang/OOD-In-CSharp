using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
	public class SingletonSample
	{
		public static void Run()
		{
			Console.WriteLine("\tSingleton\t");

			var obj1 = Singleton.Instance;
			var obj2 = Singleton.Instance;

			Console.WriteLine($"obj1 equals to obj2? {obj1 == obj2}");


			var instance1 = Singleton<SingletonClass>.Instance;
			var instance2 = Singleton<SingletonClass>.Instance;
			Console.WriteLine($"instance1 equals to instance2? {instance1 == instance2}");
		}
	}
}
