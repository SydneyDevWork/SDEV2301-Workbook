class Program
{
    static void Main()
    {
        double cups = GetCups();
        double ounces = CupToOunces(cups);
        DisplayResult(cups, ounces);
    }

    static double CupToOunces(double cups) => cups * 8.0; 

    static void DisplayResult(double cups, double ounces)
    {
        Console.WriteLine($"{cups} cups = {ounces} fluid ounces.");
    }

    static double GetCups()
    {
        double cups = 0;
        Console.Write("Enter the number of cups: ");
        // cups = double.Parse(Console.ReadLine() ?? "");
        while (!double.TryParse(Console.ReadLine(), out cups))
        {
            Console.WriteLine("Invalid input, not a number Try again");
        }
        return cups;
    }
}