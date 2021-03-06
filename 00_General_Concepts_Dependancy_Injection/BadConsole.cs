﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_General_Concepts_Dependancy_Injection
{
	public class BadConsole : IConsole
	{
		public ConsoleKeyInfo ReadKey()
		{
			return Console.ReadKey();
		}

		public string ReadLine()
		{
			return Console.ReadLine();
		}

		public void Write(string s)
		{
			Console.Write("This is the Bad Console");
			Console.WriteLine(s);
		}

		public void WriteLine(string s)
		{
			Console.WriteLine("This is the Bad Console");
			Console.WriteLine(s);
		}

		public void WriteLine(object o)
		{
			Console.WriteLine(o);
		}

		public void Clear()
		{
			Console.Clear();
		}
	}
}
