using System;

namespace ConsoleAtHome.Input;

public static partial class Cah
{
	/// <summary>
	/// Lock the user into an infinite loop until they provide a parseable string.
	/// </summary>
	/// <typeparam name="T">Return and parse type. ie: int</typeparam>
	/// <returns></returns>
	public static T? ParseLine<T>(string prompt, bool clearEachTry = false) where T : IParsable<T>
	{
		while (true)
		{
			if (clearEachTry)
				Console.Clear();

			Console.Write(prompt);

			if (T.TryParse(Console.ReadLine(), null, out T? result))
				return result;
		}
	}
}