using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
	class User
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
			Console.WriteLine($"Ваша масса тела: {i}");

		}

		public void PrintCentr()
		{
			Console.WriteLine($"\n{secondname}{name} из {town} ");
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
