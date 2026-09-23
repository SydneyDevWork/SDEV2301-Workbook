// Output prompt
Console.Write("Enter your name: ");

// Reading text input
string name = Console.ReadLine();

// Reading numeric input (requires parsing string to int)
Console.Write("Enter your age: ");
int userAge = int.Parse(Console.ReadLine());

// Formatting output using string interpolation ($"")
Console.WriteLine($"Hello, {name}! Next year you will be {userAge + 1}.");