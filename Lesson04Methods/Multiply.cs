class Program
{
static void Main()
{
Console.WriteLine(Multiply(4, 5));
}
static int Multiply(int x, int y)
{
return x * y;
}
}

// Change: use arguments 7 and 3, then run

class Program
{
static void Main()
{
Console.WriteLine(Multiply(7, 3));
}
static int Multiply(int x, int y)
{
return x * y;
}
}

// The actual concrete values passed into the 
// method when it is called in Main(). Here, 7 is assigned 
// to parameter x and 3 is assigned to parameter y.