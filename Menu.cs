using System;
using ConsoleAtHome.Scenes;

class Menu : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{
		while (true)
		{
			Console.WriteLine("Write exit...");

			if ((Console.ReadLine() ?? string.Empty) == "exit")
				return new SceneTransition.Pop();
		}
	}
}