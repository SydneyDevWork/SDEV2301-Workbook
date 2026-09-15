Random random = new();
int a = random.Next(1, 10);
int b = random.Next(1, 10);
if (a < b) 
{
    // Swap using Tuples
    (a, b) = (b, a);
}
// Determine the correct answer 
int correctAnswer = a - b;
// Prompt user for answer 
Console.Write($"What is {a} - {b} = ?");
int userAnswer = int.Parse(Console.ReadLine() ?? "");
// Print correct or display the correct answer 
if (userAnswer == correctAnswer)
{
    Console.WriteLine("Correct");
}
else
{
    Console.WriteLine($"{userAnswer} is incorrect, correct answer is {correctAnswer}");
}