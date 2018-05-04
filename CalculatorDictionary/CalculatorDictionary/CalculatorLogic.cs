using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDictionary
{
	public static class CalculatorLogic
	{
		public static bool Check(bool a)
		{
			Console.WriteLine("Jeśli chcesz użyć kalkulatora ponownie, wciśnij Y ");
			var answer = Console.ReadKey();
			if (answer.Equals("Y")) a = true;
			else a = false;
			return a;
		}
	}
}
