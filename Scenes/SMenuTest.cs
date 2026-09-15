using System;
using ConsoleAtHome;

class SMenuTest : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{
		Menu menu = new(
			[new("Do something cool", "COOL"),
			new("Do something lame", "LAME"),
			new("Exit", "EXIT")], indexOffset: 1);

		while (true)
		{
			Console.Clear();
			Console.WriteLine("===== *: Cool stuff _* =====");
			Console.WriteLine(menu.GetIndexedActions());

			string? Identifier = menu.GetActionIdentifier(Cah.Input.ParseLine<int>("Val: "));

			switch (Identifier)
			{
				case "COOL":
					Console.WriteLine("That's so cool!!");
					break;
				case "LAME":
					Console.WriteLine("That's lame bro...");
					break;
				case "EXIT":
					return new SceneTransition.Pop();
				default:
					Console.WriteLine("Not a valid input!");
					break;

			}

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}
	}
}