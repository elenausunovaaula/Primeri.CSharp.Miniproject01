﻿using System;
namespace UserInput
{
	public class UInput
	{
		About.Me about = new About.Me();
		
		public UInput()
		{
			Console.WriteLine ("Добре дошли в " + about.shortName + "\n" + about.version);
		}

		public void sayHello ()
		{ 
			
		}

		public void getUserCommands ()
		{ 
			string _command = "";

				do
				{

					//Вземане на команда

					Console.Write("$ ");
					_command = Console.ReadLine();

					//Проверка за налични команди

				if (_command.ToLower().Contains ("команда1") ) 		Console.WriteLine("Стартирана е Команда 1\n");
				if (_command.ToLower().Contains ("команда2") ) 		Console.WriteLine("Стартирана е Команда 2\n");
				if (_command.ToLower().Contains ("команда3") ) 		Console.WriteLine("Стартирана е Команда 3\n");


			} while (_command.ToLower() != "изход");
			}

		public void justTesting()
		{
			Console.WriteLine("Стариране на UserInput.UInput.justTesting ()");
		}
	}
}
