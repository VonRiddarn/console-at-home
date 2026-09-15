using System;
using ConsoleAtHome;
using ConsoleAtHome.Scenes;

namespace ConsoleAtHome;

class Program
{
	static void Main()
	{
		Console.Clear();
		SceneManager sm = new(new Menu());
	}
}