using System;
using ConsoleAtHome;

class SMenuTest : IScene
{
	SceneTransition? _deferredTransition;

	public void Enter()
	{
		_deferredTransition = null;
	}

	public void Exit() { }

	public SceneTransition Run()
	{
		Menu menu = new(
			[new("Do something cool!", HandleCool),
			new("Do something lame?", HandleLame),
			new("Exit", HandleExit)], indexOffset: 1);

		while (true)
		{
			Console.Clear();
			Console.WriteLine("===== *: Cool stuff :* =====");
			Console.WriteLine(menu.GetIndexedActions());

			var action = menu.GetAction(Cah.Input.ParseLine<int>("Val: "));

			if (action != null)
				action();
			else
				Console.WriteLine("Not a valid input!");

			if (_deferredTransition != null)
				return _deferredTransition;

			Console.WriteLine("Press any key to continue...");
			Console.ReadKey();
		}

	}

	void HandleCool()
	{
		Console.WriteLine("Wow, that's so COOL!");
	}

	void HandleLame()
	{
		Console.WriteLine("Ngl, that's kinda lame bro...");
	}

	void HandleExit()
	{
		_deferredTransition = new SceneTransition.Pop();
	}

}