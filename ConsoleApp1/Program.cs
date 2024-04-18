using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
	internal class Program
	{
		class House
		{
			public string Title;
			public double S;
		}

		static string write()
		{
			string txt = "";
			House house = new House();
            Console.Write("Кол-во:");
			int count = Convert.ToInt32(Console.ReadLine());

			for(int i = 0; i < count; i++)
			{
                Console.Write("Название "+(i+1)+" дома:");
				house.Title = Console.ReadLine();
				Console.Write("Площадь "+(i+1)+" дома:");
				house.S = Convert.ToDouble(Console.ReadLine());
				txt += house.Title + " " + house.S+"\n";
                Console.WriteLine();
            }
			return txt;
        }

		static void Main(string[] args)
		{

			string text = write();
			using (StreamWriter sw = new StreamWriter("..//..//res.txt", false))
			{
				sw.WriteLine(text);
			}
		}
	}
}
