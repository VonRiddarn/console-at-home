using System;
using ConsoleAtHome.Input;

namespace ConsoleAtHome;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Hello, World!");

		int age = Cah.ParseLine<int>("Enter age: ");

		Console.WriteLine($"You are {age} years old.");

		bool likesDogs = Cah.ParseYesNo("Do you like dogs (y / n): ");

		Console.WriteLine(likesDogs ? "Nice, me too!!" : "That's a shame, they're cute!");
	}
}
