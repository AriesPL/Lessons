using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Figura
	{
		//Класс фигура со списком к которому имеют доступ только наследники 
		//и методом отрисовкой полей
		protected List<Point> lPoint;

		public void Draw()
		{
			foreach (Point p in lPoint)
			{
				p.Draw();
			}

		}

		internal bool IsHit(Figura figura)
		{
			foreach(var p in lPoint)
			{
				if (figura.IsHit(p))
					return true;
			}
			return false;
		}

		private bool IsHit(Point point)
		{
			foreach(var p in lPoint)
			{
				if (p.IsHit(point))
					return true;
			}
			return false;
		}
	}
}
