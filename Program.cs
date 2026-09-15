using System;
using ConsoleAtHome;

namespace ConsoleAtHome;

class Program
{
	static void Main()
	{
		Console.Clear();
		SceneManager sm = new();
		sm.Initialize(new SMain());

		sm.Initialize(new SMenuTest());
	}
}