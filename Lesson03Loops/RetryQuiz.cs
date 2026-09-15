Random random = new();
int a = random.Next(1, 10);
int b = random.Next(1, 10);

if (a < b) 
{
    // Swap using Tuples 
    (a, b) = (b, a);
}

// Figure out the correct answer 
int correctAnswer = a - b;

// Prompt user for the initial answer 
Console.Write($"What is {a} - {b} = ");
int answer = int.Parse(Console.ReadLine() ?? "");

// Loop until the user gets the right answer
while (answer != correctAnswer)
{
    Console.WriteLine($"{answer} is incorrect. Try again:");
    answer = int.Parse(Console.ReadLine() ?? "");
}

Console.WriteLine("Correct!"); 