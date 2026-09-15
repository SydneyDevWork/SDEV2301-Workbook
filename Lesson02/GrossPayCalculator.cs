// Ask for hourly rate 
Console.Write("What is your hourly rate? ");
string rateInput = Console.ReadLine();

// Ask for how many hours worked 
Console.Write("How many hours have you worked? ");
string hoursInput = Console.ReadLine();

// Parse both values into decimals
decimal rate = decimal.Parse(rateInput);
decimal hours = decimal.Parse(hoursInput);

// Calculate the rate and the hours 
decimal grossPay = rate * hours;

// Display the labelled currency result ("C" formats it as local currency)
Console.WriteLine($"Gross Pay: {grossPay:C}");

// Test with 25 and 40 

// Instructor walkthrough

// Introduce the program to the end user 
Console.Writeline("This app calculates the weekly pay for an hourly wage employee.");
// Prompt for hourly rate
Console.Write("Enter hourly rate: ");
// Read input and convert it to a double type
string userInput = Console.ReadLine();
decimal hourlyRate = decimal.Parse(userInput);
// Prompt and read the hours worked
Console.Write("Enter hours worked: ");
userInput = Console.ReadLine() ?? "";
double hoursWorked = double.Parse(userInput);
// Calculate and display the gross pay
var grossPay = hourlyRate * (decimal) hoursWorked;
// Display results
Console.WriteLine($"Your Gross Pay is: {grossPay:C}");
