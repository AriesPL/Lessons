using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeWork2
{
	class Program
	{
		static void Main(string[] args)
		{
			//1:Метод возвращающий минимальное из 3 чисел. 
			#region Минимальное значение

			MinNumber();

			#endregion

			//2:Метод подсчета цифр числа.

			int x = 12345;
			
			string y = Convert.ToString(x);
			
				
			foreach()

			Console.Read();
		}

		private static void MinNumber()
		{
			int x = 10;
			int y = 20;
			int z = 6;

			if (x < y && x < z)
			{
				Console.WriteLine(x);
			}
			else if (y < x && y < z)
			{
				Console.WriteLine(y);
			}
			else
				Console.WriteLine(z);
		}
	}
}
