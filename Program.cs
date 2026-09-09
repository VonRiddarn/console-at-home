using System;
using ConsoleAtHome;

namespace ConsoleAtHome;

class Program
{
	static void Main()
	{
		Console.WriteLine("Hello, World!");

		int age = Cah.ParseLine<int>("Enter age: ");
		Console.WriteLine($"You are {age} years old.");

		bool likesDogs = Cah.ParseYesNo("Do you like dogs (y / n): ");
		Console.WriteLine(likesDogs ? "Nice, me too!!" : "That's a shame, they're cute!");

		string[] animals = ["dogs", "cats", "birds", "mice", "sheep"];

		int index = Cah.ParseCustom("What's your favorite animal: ", animals);
		Console.WriteLine($"Cool! I like {animals[index]} too!");

		for (int i = 0; i < animals.Length; i++)
			Console.WriteLine($"{i + 1}) {animals[i]}");

		string animal = Cah.SelectFromIndex<string>("Choose: ", animals, indexCorrection: -1);
		Console.WriteLine($"Choice = {animal}.");
	}
}