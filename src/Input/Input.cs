using System;

namespace ConsoleAtHome.Input;

public static partial class Cah
{
	/// <summary>
	/// Lock the user into an infinite loop until they provide a parseable string.
	/// </summary>
	/// <typeparam name="T">Return and parse type. ie: int</typeparam>
	/// <returns></returns>
	public static T? ParseLine<T>(string prompt, bool clear = false) where T : IParsable<T>
	{
		while (true)
		{
			ClearAndPrompt(prompt, clear);

			if (T.TryParse(Console.ReadLine(), null, out T? result))
				return result;
		}
	}

	public static bool ParseYesNo(string prompt, bool clear = false)
	{
		string[] yesCol = ["ja", "y", "j", "1"];
		string[] noCol = ["nej", "n", "0"];

		while (true)
		{
			ClearAndPrompt(prompt, clear);
			string? input = Console.ReadLine()?.ToLower();

			if (yesCol.Contains(input))
				return true;
			else if (noCol.Contains(input))
				return false;
		}
	}

	// ----- ----- -----
	//		HELPERS
	// ----- ----- -----

	static void ClearAndPrompt(string prompt, bool clear)
	{
		if (clear)
			Console.Clear();

		Console.Write(prompt);
	}
}