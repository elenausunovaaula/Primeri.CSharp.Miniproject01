﻿using System;
namespace Calculations
{
	public class Formula01
	{
		//Библиотеки
		private Colors.ForCLI _c = new Colors.ForCLI();

		public Formula01 ()	//Формула за обикновена строителна яма
		{
		}

		//Парсване
		public void calc(string _userInput)
		{
			try
			{
				string[] param = _userInput.Split(' ');

				if (param.Length > 1 && _userInput.Contains("-п"))
				{
					//Помощ за командата
					help();
				}


				//Да я изпълним командата
				if (param.Length > 1 && !_userInput.Contains("-п"))
				{
					//Изчисления

					double _result = 0;

					if (runCalculations(param, out _result))
					{
						_c.Default ();	Console.Write ("Обемът на строителната яма е: ");
						_c.Result ();	Console.Write (_result.ToString("N1"));
						_c.Default();	Console.WriteLine(" м3\n");
					}
					else {
						_c.Default (); Console.WriteLine ("Има грешно въведени параметри. Можете да проверите синтаксиса с параметър '-п'\n");
					}
				}


			}
			catch
			{

			}
		}

		//Изчисления и изписване
		//Проверяваме дали правилно сме парснали

		private bool runCalculations(string[] _param, out double _result)
			{
			try {
					double _a1 = 0, _b1 = 0, _a2 = 0, _b2 = 0,_h = 0;

					//param[0] == <име на команда>

					Double.TryParse(_param[1], out _a1);
					Double.TryParse(_param[2], out _b1);
					Double.TryParse(_param[3], out _a2);
					Double.TryParse(_param[4], out _b2);
					Double.TryParse(_param[5], out _h);

					double F1 = _a1 * _b1, F2 = _a2 * _b2;
					_result = _h * (F1 + F2) / 2;

				return true;
			}catch{
			}
			_result = 0;
			return false;
			}




		//Помощ за командата
		private void help()
		{ 
			_c.Result(); Console.Write("\n[яма]");
			_c.Default(); Console.WriteLine(" - команда за пресмятане на строителна яма");

			_c.Command(); Console.Write("параметри: ");
			_c.Default(); Console.WriteLine("a1 b1 a2 b2 h\n");

			_c.Command(); Console.Write("a1 и b1 ");
			_c.Default(); Console.WriteLine(" - ширина и дължина на горната страна на изкопа");

			_c.Command(); Console.Write("a2 и b2 ");
			_c.Default(); Console.WriteLine(" - ширина и дължина на долната страна на изкопа");

			_c.Command(); Console.Write("a2 и b2 ");
			_c.Default(); Console.WriteLine(" - височина на изкопа");
		
		}
	}
}
