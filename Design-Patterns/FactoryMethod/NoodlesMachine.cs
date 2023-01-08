using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod
{
	class NoodlesMachine:Machine
	{
		public override Product Process()
		{
			return new Noodles();
		}
	}
}
