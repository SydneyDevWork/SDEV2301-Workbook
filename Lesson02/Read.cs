// Prompt and read the users death
Console.Write("Your Death Age: ");
string death = Console.ReadLine() ?? "no input";
// Print the death using string interpolation
Console.WriteLine($"You will die at: {death} years old!");

