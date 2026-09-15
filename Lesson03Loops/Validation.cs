// Console.Write("Enter a team size between 9 and 15: ");
// int teamSize = int.Parse(Console.ReadLine() ?? "");
// while (teamSize < 9 || teamSize > 15)
// {
//     Console.Write($"incorrect. Try again: ");
//     teamSize = int.Parse(Console.ReadLine() ?? "");
// }

int teamSize;
do
{
    Console.Write("Enter a team size between 9 and 15: ");
    teamSize = int.Parse(Console.ReadLine() ?? "");
} while (teamSize < 9 || teamSize > 15);