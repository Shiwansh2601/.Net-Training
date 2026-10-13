using System;

// ENUM EXAMPLE
// An enum is a value type that assigns readable names to a set of related constants.
enum WorkDay
{
	Monday,
	Tuesday,
	Wednesday,
	Thursday,
	Friday
}

// STRUCT EXAMPLE
// A struct is a value type that groups related data into one unit.
struct Point
{
	public int X;
	public int Y;

	public Point(int x, int y)
	{
		X = x;
		Y = y;
	}
}

class Program
{
	static void Main()
	{
		// Using the enum
		WorkDay today = WorkDay.Monday;
		Console.WriteLine($"Today is {today}.");

		// Using the struct
		Point location = new Point(10, 20);
		Console.WriteLine($"Point: ({location.X}, {location.Y})");
	}
}
