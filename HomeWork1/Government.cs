using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
	 public class Government
	{
		
		public void Pause() 
		{
			Console.Read();
		}

		public void Print(string x)
		{
		   Console.WriteLine(x);
		}
		public void Print(int x)
		{
			Console.WriteLine(x);
		}

		public void Print(object x)
		{
			Console.WriteLine(x);
		}
	}
}
