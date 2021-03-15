using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace HomeWork1
{
	class Program
	{
		static void Main(string[] args)
		{

			/*1:Написать программу "анкета" (Имя, фамилия, возраст, рост, вес)
			а)использование склеивание
			б)использовать форматированый вывод
			в)использовать вывод со знаком $
			*/

			//Программа не защищена от дурака
			Government go = new Government();
			User people = new User();
			
			#region Запрос информации от пользователя и вывод ее.

			Console.WriteLine("Введите ваше Имя");
			people.name = Console.ReadLine();

			Console.WriteLine("Введите вашу Фамилию");
			people.secondname = Console.ReadLine();

			Console.WriteLine("Введите ваш Возраст");
			people.old = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("Введите ваш Вес");
			people.weight = Convert.ToDouble(Console.ReadLine());

			Console.WriteLine("Введите ваш Рост");
			people.hieght = Convert.ToDouble(Console.ReadLine());

			
			people.Print();

			Thread.Sleep(2000);

			#endregion

			// 2:Расчитать и вывести индекс массы тела.

			#region Индекс массы тела

			Console.WriteLine("\nИндекс массы тела");
			people.IMT();

			Thread.Sleep(2000);
			#endregion

			/* 3:Подсчитать растояние между двумя точками  с координатами x1,x2, y1,y2
			 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2))
			 оформить вычесления растояния виде метода.*/
			#region Подсчет растояния

			int x1 = 2;
			int x2 = 4;
			int y1 = 1;
			int y2 = 3;
			double r = Lenght(x1, x2, y1, y2);
			string text = $"\nТочки равны: \n x1 = {x1}; \n x2 = {x2}; \n y1 = {y1}; \n y2 = {y2}; \nРастояние между точками: {r}";
			
			go.Print(text);
			
			Thread.Sleep(2000);
			#endregion

			/* 4:Программа обмена значениями:
				а)С использованием третей переменной.
				б)без использования третей переменной.
			*/
			#region Обмен значений
			int x = 5;
			int y = 10;
			int z;
			text = $"До обмена:\nx = {x}\ny = {y}";

			go.Print(text);

			z = x;
			x = y;
			y = z;
			text = $"После обмена с третей переменной:\nx = {x}\ny = {y}";
			
			go.Print(text);

			x = x + y;
			y = x - y;
			x = x - y;
			text = $"После обмена с третей переменной:\nx = {x}\ny = {y}";

			go.Print(text);

			Thread.Sleep(1000);
			#endregion

			/* 5:Программа которая выводит Имя, Фамилию, Город проживания.
				а)Организовать вывод в центре консоли.
				б)Сделать собственные методы Вывода.
			*/
			#region Вывод текста по центру
			User people2 = new User("Alexey", "Sergeev", "Tomsk");
			people2.PrintCentr();
			#endregion

			//6: Создать свой класс с методами Print , Pause.
			//Class Goverment ( Включает в себя методы Print , Pause )

			go.Pause();
		}

		private static double Lenght(int x1, int x2, int y1, int y2)
		{
			return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
		}
	}
}
