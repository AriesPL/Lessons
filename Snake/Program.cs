using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			// Размер окна консоле
			Console.SetBufferSize(120, 30);

			
			// Отрисовка полей в консоле
			HorizontalLine horLineUp = new HorizontalLine(0,119,0,'+');
			HorizontalLine horLineDown = new HorizontalLine(0, 119, 28, '+');
			VerticalLine verticalLineLeft = new VerticalLine(0, 0, 28, '|');
			VerticalLine verticalLineRight = new VerticalLine(119, 0, 28, '|');
			horLineUp.Draw();
			horLineDown.Draw();
			verticalLineLeft.Draw();
			verticalLineRight.Draw();


			Point p = new Point(4, 5, '#');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();

			FoodBilder foodBilder = new FoodBilder(118, 27, '8');
			Point food = foodBilder.GiveMeFood();
			food.Draw();


			
			while(true)
			{
				if(snake.Eat(food))
				{
					food = foodBilder.GiveMeFood();
					food.Draw();
				}
				else
				{
					snake.Move();
				}
				
				Thread.Sleep(100);

				if(Console.KeyAvailable)
				{
					ConsoleKeyInfo key = Console.ReadKey();
					snake.HandKey(key.Key);
					
				}
				Thread.Sleep(100);
				snake.Move();

			}



			Console.ReadLine();
		}

		
	}
}
