using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.SimpleFactory
{
	public class ShapeFactory
	{
		public static Shape GetShape(ShapeType shapeType)
		{
			switch(shapeType)
			{
				case ShapeType.Circle:
					return new Circle();
				case ShapeType.Rectangle:
					return new Rectangle();
				default:
					throw new NotSupportedException();
			}
		}
	}
}
