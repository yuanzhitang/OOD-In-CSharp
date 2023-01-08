using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryMethod
{
	class NoodlesFactory: Factory
	{
		protected override Machine CreateMachine()
		{
			return new NoodlesMachine();
		}
	}
}
