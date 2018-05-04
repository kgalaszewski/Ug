using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDictionary
{
	class Program
	{

		static void Main(string[] args)
		{
			bool UserWantsToUseIt = true;

			while (UserWantsToUseIt)
			{
				Operation ObjectCalculator = new Operation();

				Console.WriteLine("Jaką operację chciałbyś wykonać");
				string ChosenOperation = Console.ReadLine();
				Operation.SetEnum(ChosenOperation);


				Console.WriteLine("Podaj 1 liczbę");
				ObjectCalculator.a = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("Podaj 2 liczbę");
				ObjectCalculator.b = Convert.ToDouble(Console.ReadLine());


				double Result = ObjectCalculator.Count(ObjectCalculator.a, ObjectCalculator.b);
				Console.WriteLine($"Wybrana operacja to: {ChosenOperation}, podane liczby to {ObjectCalculator.a} oraz {ObjectCalculator.b}. ");
				Console.WriteLine($"Wynik operacji to : {Result}");


				CalculatorLogic.Check(UserWantsToUseIt);
			}

		}
	}
}
