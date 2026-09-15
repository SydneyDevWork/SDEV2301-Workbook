    class Program
    {
        static void Main()
        {
            // Call DisplayBanner() twice from Main
            DisplayBanner();
            DisplayBanner();
        }

        // Refactored static void DisplayBanner() method below Main
        static void DisplayBanner()
        {
            Console.WriteLine("====================");
            Console.WriteLine("Lesson 4");
            Console.WriteLine("====================");
        }
    }

    // Instructors code:
//     class Program
// {
//     static void Main()
// }
