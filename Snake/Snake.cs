﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Snake : Figura
	{
		 Direction direction;
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
			head.Draw();
		}

		private Point GetNextPoint()
		{
			Point head = lPoint.Last();
			Point nextPoint = new Point(head);
			nextPoint.Move(1, direction);
			return nextPoint;
		}

		public void HandKey(ConsoleKey key)
		{
			if (key == ConsoleKey.RightArrow && direction != Direction.LEFT)
				direction = Direction.RIGHT;
			else if (key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
				direction = Direction.LEFT;
			else if (key == ConsoleKey.DownArrow && direction != Direction.UP)
				direction = Direction.DOWN;
			else if (key == ConsoleKey.UpArrow && direction != Direction.DOWN)
				direction = Direction.UP;
		}

		internal bool Eat(Point food)
		{
			Point head = GetNextPoint();
			if (head.IsHit(food))
			{
				food.sym = head.sym;
				lPoint.Add(food);
				return true;
			}
			else
				return false;
		}
		
		internal bool IsHitTail()
		{
			var head = lPoint.Last();
			for(int i=0; i<lPoint.Count - 2; i++)
			{
				if (head.IsHit(lPoint[i]))
					return true;
			}
			return false;
		}
	}
}
