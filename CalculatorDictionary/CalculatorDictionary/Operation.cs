using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDictionary
{
	public class Operation
	{
		public double result;
		public double a;
		public double b;
		WhatToDo asd = new WhatToDo();

		#region SetEnum
		public static WhatToDo SetEnum(string ChosenOperation)
		{
			switch (ChosenOperation)
			{
				case "dodawanie":
					return WhatToDo.dodawanie;
					break;
				case "odejmowanie":
					return WhatToDo.odejmowanie;
					break;
				case "dzielenie":
					return WhatToDo.dzielenie;
					break;
				case "pierwiastkowanie":
					return WhatToDo.pierwiastkowanie;
					break;
				case "mnozenie":
				case "mnożenie":
					return WhatToDo.mnozenie;
					break;
				case "potegowanie":
				case "potęgowanie":
					return WhatToDo.potegowanie;
					break;
				default:
					Console.WriteLine("Nie ma takiej operacji");
					return WhatToDo.unknown;
					break;
			}
		}
		#endregion

		#region Liczydełko
		/// <summary>
		/// może być liczba zmiennoprzecinkowa
		/// </summary>
		/// <param name="a">pierwsza liczba</param>
		/// <param name="b">druga liczba</param>
		/// <returns></returns>
		public double Count(double a, double b)
		{
			a = this.a;
			b = this.b;
			switch (this.asd)
			{
				case WhatToDo.dodawanie: result = a + b;  
					break;
				case WhatToDo.odejmowanie: result = a - b;
					break;
				case WhatToDo.mnozenie: result = a * b;
					break;
				case WhatToDo.dzielenie: result = a / b;
					break;
				case WhatToDo.potegowanie: result = Math.Pow(a, b);
					break;
				case WhatToDo.pierwiastkowanie: result = Math.Pow(a, 1 / b);
					break;				
				default: Console.Error.WriteLine("Podałeś/aś nieprawidłową operację");
					break;
			}
			return result;
		}
		#endregion

	}
}
