using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figura
	{
		public Direction direction;
		public Snake(Point tail, int lenght, Direction _direction)
		{
			direction = _direction;
			lPoint = new List<Point>();

			//Цикл по созданию змейки
			for(int i = 0; i < lenght; i++)
			{
				Point p = new Point(tail);
				p.Move(i, direction);
				lPoint.Add(p);
	
			}

		}

		internal void Move()
		{
			Point tail = lPoint.First();
			lPoint.Remove(tail);
			Point head = GetNextPoint();
			lPoint.Add(head);

			tail.Clear();
			head.Drow();
		}

		private Point GetNextPoint()
		{
			Point head = lPoint.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}
	}
}
