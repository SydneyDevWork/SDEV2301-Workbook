class Program
{
    static void Main()
    {
        Console.WriteLine(MaxValue(4, 9));
        Console.WriteLine(MaxValue(4.5, 9.2));
    }

    static int MaxValue(int a, int b)
    => a > b ? a : b;

    static double MaxValue(double a, double b)
    => a > b ? a : b;

}
// Predict: which class method each call selects
// MaxValue(4, 9) calls the integer 
// version of MaxValue because both numbers are whole integers.
// MaxValue(4.5, 9.2) calls the double version of 
// MaxValue because both numbers have decimals.