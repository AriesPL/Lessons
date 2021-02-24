using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			#endregion

			#region Индекс массы тела
			people.IMT();
			#endregion



			Console.Read();
		}
	}
}
