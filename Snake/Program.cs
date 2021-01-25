using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Point p1 = new Point(1,2,'%');

			p1.Drow();

			HorizontalLine horLineUp = new HorizontalLine(0,50,0,'+');
			HorizontalLine horLineDown = new HorizontalLine(0, 50, 25, '+');
			VerticalLine verticalLineLeft = new VerticalLine(0, 0, 25, '|');
			VerticalLine verticalLineRight = new VerticalLine(50, 0, 25, '|');
			horLineUp.Drow();
			horLineDown.Drow();
			verticalLineLeft.Drow();
			verticalLineRight.Drow();

			Console.ReadLine();
		}

		
	}
}
