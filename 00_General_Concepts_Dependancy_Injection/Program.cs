using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependancy_Injection
{
	class Program
	{
		static void Main(string[] args)
		{
			ProgramUI goodConsole = new ProgramUI(new GoodConsole());
			goodConsole.Run();
			ProgramUI program = new ProgramUI(new BadConsole());
			program.Run();
			ProgramUI uglyConsole = new ProgramUI(new UglyConsole());
			uglyConsole.Run();
		}
	}
}
