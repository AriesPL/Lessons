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

		public void Drow()
		{
			foreach (Point p in lPoint)
			{
				p.Drow();
			}

		}
	}
}
