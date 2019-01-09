using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	//Question1:
	class Program
	{
		static void Main(string[] args)
		{
			Arrnew();
		}
		private static int Measure(int[] a, int[] b)
		{
			int lng;
			int counterA = 0,counterB=0;
			if (a.Length<=b.Length)
			lng = a.Length;
			else
			lng = b.Length;
			for (int i = 0; i < lng; i++)
			{
				if (a[i] > b[i])
				{
					counterA++;
				}
				else if (b[i] > a[i])
				{				
					counterB++;
				}
			}

			if (counterA > counterB)
				return 1;
			else if (counterB > counterA)
				return -1;
			else
				return 0;

		}
		private static void Arrnew()
		{
			Random rnd = new Random();
			int sizeA = rnd.Next(3, 10);
			int sizeB = rnd.Next(3, 10);
			int[] a= new int[sizeA];
			int[] b = new int[sizeB];
			for (int i = 0; i <a.Length; i++)
			{
				a[i] = rnd.Next(1, 100);
			}
			for (int i = 0; i < b.Length; i++)
			{
				b[i] = rnd.Next(1, 100);
			}
			int result=Measure(a, b);
			switch (result)
			{
				case 1:
					Console.WriteLine("Array A weighs more!");
					break;
				case -1:
					Console.WriteLine("Array B weighs more!");
					break;
				case 0:
					Console.WriteLine("Draw!");
					break;
				default:
					Console.WriteLine("error");
					break;
			}
		}
		

	}
}
