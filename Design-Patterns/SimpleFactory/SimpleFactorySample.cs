using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SimpleFactory
{
	class SimpleFactorySample
	{
		public static void Run()
		{
			Console.WriteLine("\tSimpleFactory\t");

			/* There are two ways to implement simple factory mode
			 * 
			 * #1 Put the static GetShape method to a seperate class, e.g ShareFactory.GetShape(...)
			 * #2 Put the static GetShare method to the abstract Shape base class, e.g. Shape.GetShape(...)
			 * 
			 */
			var circle = ShapeFactory.GetShape(ShapeType.Circle);
			var rectangle = ShapeFactory.GetShape(ShapeType.Rectangle);

			circle.Print();
			rectangle.Print();
		}
	}
}
