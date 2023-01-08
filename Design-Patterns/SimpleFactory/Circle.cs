using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SimpleFactory
{
	public class Circle:Shape
	{
		public override void Print()
		{
			Console.WriteLine("Print Circle");
		}
	}
}
