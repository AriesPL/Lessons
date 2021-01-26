using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figura
	{
		public Snake(Point tail, int lenght, Direction direction)
		{

			lPoint = new List<Point>();

			//Цикл по созданию змейки
			for(int i = 0; i < lenght; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				lPoint.Add(p);
				

				
			}

		}

	}
}
