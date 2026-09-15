using static System.Console; // Enables direct access to all static methods in Console class
// Prompt for age 
// Console.Write("What is your age? ");
Write("What is your age? ");
// int age = (ReadLine); = Error message 
int age = int.Parse(ReadLine() ?? "0"); 
if (age >= 18)
{
    WriteLine("Adult");
}
// C# case sensetive while Python is not
// ?? "" <--- required 
// Always include ; 

// What you already know:
// • if / else structure
// • comparison operators
// • block-based logic
// What’s different in C#:
// • Condition must be bool
// • Braces are strongly encouraged
// • Compiler rejects ambiguous logic
if (age >= 18)
{
Console.WriteLine("Access granted");
}
else
{
Console.WriteLine("Access denied");
}
// Runs at least once -- even if condition is false
int input;
do
{
Console.WriteLine("Enter a number greater than 0:");
input = int.Parse(Console.ReadLine());
}
while (input <= 0);