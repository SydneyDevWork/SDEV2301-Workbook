using System.Security.Authentication.ExtendedProtection;

class Program
{
    static void Main()
    {
        int value = 20; 
        ChannelBinding(value);
        Console.WriteLine(value); 
    }
    static void Change(int num)
    {
        num = 100;
    }
}

// Precdiction 20 because it doesn't give show the changed value
