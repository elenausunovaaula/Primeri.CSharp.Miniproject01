﻿using System;
namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me ();
		Colors.ForCLI _c = new Colors.ForCLI ();
		Calculations.MainLibrary _calc = new Calculations.MainLibrary();

		
		public UInput()
		{
			
		}

		public void sayHello ()
		{ 
			_c.Default ();
			Console.WriteLine ("Добре дошли в " + about.shortName + "\n" + about.version);
		}

		public void getUserCommands ()
		{ 
			string _command = "";

				do
				{

					//Вземане на команда
				_c.Prompt ();		Console.Write("$ ");
				_c.Command ();		_command = Console.ReadLine();

				//Проверка за налични команди

				if (_command.ToLower().Contains ("яма") ) 		_calc.F01.calc (_command );

				if (_command.ToLower().Contains ("въгъл") )		_calc.F02.calc (_command );		
				if (_command.ToLower().Contains ("команда3") ) 		Console.WriteLine("Стартирана е Команда 3\n");


			} while (_command.ToLower() != "изход");
			}

		public void justTesting()
		{
			Console.WriteLine("Стариране на UserInput.UInput.justTesting ()");
		}
	}
}
