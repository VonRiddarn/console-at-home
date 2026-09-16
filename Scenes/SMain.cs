using System;
using System.Text;
using ConsoleAtHome;

class SMain : IScene
{
	public void Enter() { }

	public void Exit() { }

	public SceneTransition Run()
	{
		Wizard builder = new("== Accumulative menu test ('exit' to exit) ==");
		string input;

		while (true)
		{
			input = builder.GetNext("Text: ", "> ");

			if (input == "exit")
				return new SceneTransition.Pop();

		}
	}
}