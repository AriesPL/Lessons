using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWork1;



namespace HomeWork2
{
	class Program
	{
		static void Main(string[] args)
		{
			Government go = new Government();

			//1:Метод возвращающий минимальное из 3 чисел. 
			#region Минимальное значение
			go.Print("Task 1: Возврат минимального значения \n");
			MinNumber();

			#endregion

			//2:Метод подсчета цифр числа.
			#region Колличества знаков
			go.Print("\nTask 2: Метод подсчета колличества знаков в числе");

			int x = 12345;

			string y = Convert.ToString(x);

			int count = CharCount(y);

			go.Print($"\n{count}");
			#endregion

			//3:Подсчет суммы всех веденных нечетных чисел введенных ползователем пока не будет веден 0.



			//4:Проверка Логина и пароля. login = root, Pass = GeekBrains.
			#region Проверка
			string login;
			string pass;
			int count1 = 0;

			do 
				{
					
					go.Print("Login:");
					login = Convert.ToString(Console.ReadLine());

					go.Print("Password:");
					pass = Convert.ToString(Console.ReadLine());

					
					count1++;
					
				}
				while (login != "root" && pass != "GeekBrains" && count1 < 3);
			if(login == "root" && pass == "GeekBrains")
			{
				go.Print("You enter. Welcome.");
			}
			else  			
				go.Print("You Chanse over.");

			#endregion

			/*5:а)Улутшить программу IMT
				б)Расчитать на сколько надо похудеть или набрать.
			 
			 Данное задание имеет ссылку на проэкт HomeWork1*/
			#region IMT 0.1
			User people = new User();
			go.Print("Введите ваш Вес");
			people.weight = Convert.ToDouble(Console.ReadLine());

			go.Print("Введите ваш Рост");
			people.hieght = Convert.ToDouble(Console.ReadLine());

			people.IMT();

			#endregion

			//6:Подсчет хороших чисел от 1 до 1000000000, и сколько времени это займет, используя DateTime.

			#region Хорошие числа.

			int minNum = 1;
			int maxNum = 1000000;
			int goodNumber = 0;
			int temp;
			int testnum;
			DateTime startTime = DateTime.Now;
			go.Print(startTime);

			for (int i = minNum; i < maxNum; i++)
			{
				temp = 0;
				testnum = i;
				while (testnum != 0)
				{
					temp += testnum % 10;
					testnum /= 10;
				}
				if (i % temp == 0) 
					goodNumber++;
			}
			DateTime finishTime = DateTime.Now;
			TimeSpan durationTime = finishTime - startTime;
			go.Print($"\n{goodNumber}\n{durationTime}");
			#endregion 

			/*7:a)Рекурсивный метод который выводит числа от a до b (a<b)
				б)Рекурсивный метод который считает сумму от a до b
			*/



			go.Pause();
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
