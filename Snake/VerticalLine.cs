using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class VerticalLine : Figura
	{
		////Класс вертикальных линий наследуемый от фигуры с созданием точек.
		public VerticalLine(int x, int yLeft,int yRight, char sym)
		{
			lPoint = new List<Point>();
			for(int y = yLeft; y <= yRight; y++)
			{
				Point p = new Point(x, y, sym);
				lPoint.Add(p);
			}

		}
	}
}
