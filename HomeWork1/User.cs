using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
	public class User
	{
		//Создание класса не входит в эту домашнную работу.
		public string name;
		public string secondname;
		public int old;
		public double weight;
		public double hieght;
		public string town;

		public User()
		{

		}

		public User(string name, string secondname, string town)
		{
			this.name = name;
			this.secondname = secondname;
			this.town = town;
		}

		public User(string name, string secondname,int old,double weight,double hieght)
		{
			this.name = name;
			this.secondname = secondname;
			this.old = old;
			this.weight = weight;
			this.hieght = hieght;
		}

		public void IMT()
		{

			double i;
			double h = hieght / 100;
			i = weight/(h*h);
			Console.WriteLine($"Ваша масса тела: {i:f1}");

			#region HomeWork2
			if (i < 16)
			{
				i = 25 - i;
				Console.WriteLine($"Ярко выраженный дефецит массы тела. \n До нормы нужно набрать {i:f1} кг.");
			}
			else if(i >= 16.0 && i < 18.5)
			{
				i = 25 - i;
				Console.WriteLine($"Дефецит массы тела. \n До нормы нужно набрать {i:f1} кг.");
			}
			else if(i >= 18.5 && i < 25)
			{
				Console.WriteLine("Норма");
			}
			else if(i >= 25 && i < 30)
			{
				i = i - 25;
				Console.WriteLine($"Предожирение. \n До нормы нужно сбросить {i:f1} кг.");
			}
			else if(i >= 30 && i < 35)
			{
				i = i - 30;
				Console.WriteLine($"Ожирение первой степени. \n До нормы нужно сбросить {i:f1} кг.");
			}
			else if(i >= 35 && i < 40)
			{
				i = i - 35;
				Console.WriteLine($"Ожирение второй стерпени. \n До нормы нужно сбросить {i:f1} кг.");
			}
			else if (i >= 45)
			{
				i = i - 40;
				Console.WriteLine($"Ожирение третей степени. \n До нормы нужно сбросить {i:f1} кг.");
			}
			else
				Console.WriteLine("Проблема, что-то сломалось.");
			#endregion
		}

		public void PrintCentr()
		{
			string text = $"{secondname} {name} из {town}a";
			var width = Console.WindowWidth;
			var paddingWidht = width / 2 + text.Length / 2;

			Console.WriteLine("\n{0," + paddingWidht + "}",text);
		}

		public void Print()
		{
			Console.WriteLine("Ваши данные:" +secondname+ " "+name+ " ваш возраст "+old+ "." +
				" Давите на землю с тяжестью в "+weight+ "кг и возвышаетесь над тараканами на "+hieght+" см");

			Console.WriteLine($"Ваши данные:{secondname}{name} ваш возраст {old}." +
				$" Давите на землю с тяжестью в {weight} кг и возвышаетесь над тараканами на {hieght} см");

			Console.WriteLine("Ваши данные:{1}{0} ваш возраст {2}." +
				" Давите на землю с тяжестью в {3} кг и возвышаетесь над тараканами на {4} см", name,secondname,old,weight,hieght);
		}




	}
}
