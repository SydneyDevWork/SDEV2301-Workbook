// Correct: 
int x = 1;
if (x == 1)
{
    Console.WriteLine("One");
}
// Predict: why if (x) and if (x = 1) are invalid
// Test: replace the condition with each alternative 
// int x = 1;
// if (x)
// {
//     Console.WriteLine("One");
// }
// int x = 1;

// if (x = 1)
// {
//     Console.WriteLine("One");
// }
// Run: dotnet BooleanCheck.cs 
