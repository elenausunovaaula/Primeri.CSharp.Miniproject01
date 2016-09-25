using System;

namespace Calculator
{
	class MainClass
	{
		//Дефиниране на библиотеки
		public UserInput.UInput uInput = new UserInput.UInput();
		public About.Me about = new About.Me();




		public static void Main(string[] args)
		{
			MainClass _program = new MainClass();

			//Форматиране на програмата
			Console.Title = _program.about.shortName +  ", " + _program.about.version;



			//Стариране на програмата
			_program.uInput.getUserCommands();
		}
	}
}
