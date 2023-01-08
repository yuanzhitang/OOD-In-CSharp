using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SimpleFactory
{
	public class Rectangle : Shape
	{
		public override void Print()
		{
			Console.WriteLine("Print Rectangle");
		}
	}
}
