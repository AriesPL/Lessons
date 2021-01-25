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
			//p1.x = 5;
			//p1.y = 10;
			//p1.sym = '%';

			p1.Drow();

			Console.ReadLine();
		}

		
	}
}
