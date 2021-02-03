using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class FoodBilder
	{
		//Класс по созданию еды для змейки. Конструктор который пнимает пораметры и метод выбора рандомной позиции для еды.
		int wightWindow;
		int hightWindow;
		char food;

		Random rnd = new Random();

		public FoodBilder(int wightWindow, int hightWindow, char food)
		{
			this.wightWindow = wightWindow;
			this.hightWindow = hightWindow;
			this.food = food;
		}

		public Point GiveMeFood()
		{
			int x = rnd.Next(2, wightWindow - 2);
			int y = rnd.Next(2, hightWindow - 2);
			return new Point(x, y, food);
		}

	}
}
