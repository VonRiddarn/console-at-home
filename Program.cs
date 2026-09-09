using System;
using ConsoleAtHome;

namespace ConsoleAtHome;

class Program
{
	static void Main()
	{
		Console.WriteLine("Hello, World!");

		int age = Cah.Input.ParseLine<int>("Enter age: ");
		Console.WriteLine($"You are {age} years old.");

		bool likesDogs = Cah.Input.ParseYesNo("Do you like dogs (y / n): ");
		Console.WriteLine(likesDogs ? "Nice, me too!!" : "That's a shame, they're cute!");

		string[] animals = ["dogs", "cats", "birds", "mice", "sheep"];

		int index = Cah.Input.ParseCustom("What's your favorite animal: ", animals);
		Console.WriteLine($"Cool! I like {animals[index]} too!");


		(string label, Action action)[] buttons =
		[
			("Säg hej", () => { Console.WriteLine("Hejsan!!"); }),
			("Skjut en pistol", () => { Console.WriteLine("PANG"); })
		];

		for (int i = 0; i < buttons.Length; i++)
			Console.WriteLine($"{i + 1}) {buttons[i].label}");

		Cah.Input.SelectFromIndex<(string label, Action action)>("Choose: ", buttons, indexCorrection: -1).action();
	}
}