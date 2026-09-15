using System;
using System.Text;
using ConsoleAtHome;

class SMain : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{
		AccumulativeMenu am = new("== Accumulative menu test ('exit' to exit) ==");
		string? input = null;

		while (true)
		{
			if (input == null)
				am.Render(suffix: "\nText: ");
			else
				am.RenderNextLine($"> {input}", suffix: "\nText: ");

			input = Console.ReadLine() ?? string.Empty;

			if (input == "exit")
				return new SceneTransition.Pop();

		}
	}
}