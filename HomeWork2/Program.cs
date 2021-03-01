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
			Console.WriteLine("Task 1: Возврат минимального значения \n");
			MinNumber();

			#endregion

			//2:Метод подсчета цифр числа.
			#region Колличества знаков
			Console.WriteLine("\nTask 2: Метод подсчета колличества знаков в числе");

			int x = 12345;

			string y = Convert.ToString(x);

			int count = CharCount(y);

			Console.WriteLine($"\n{count}");
			#endregion

			//3:Подсчет суммы всех веденных нечетных чисел введенных ползователем пока не будет веден 0.



			//4:Проверка Логина и пароля.


			//5:Улутшеная программа IMT


			//6:Подсчет хороших чисел от 1 до 1000000000, и сколько времени это займет, использую DateTime.


			/*7:a)Рекурсивный метод который выводит числа от a до b (a<b)
				б)Рекурсивный метод который считает сумму от a до b
			*/



			Console.Read();
		}

		private static int CharCount(string y)
		{
			int count = 0;
			foreach (char element in y)
			{
				count++;
			}

			return count;
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
