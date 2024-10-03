using System;

class Program
{
    static void Main(string[] args)
    {
        // Part 1: Print a string to the console
        Console.WriteLine("Hello World!");

        // Part 2: Get user input and print it to the console
        Console.WriteLine("Please enter your name:");
        string userInput = Console.ReadLine();
        Console.WriteLine("You entered: " + userInput);

        // Part 3: Get two inputs from the user and print them on separate lines
        Console.WriteLine("Please enter the first value:");
        string firstInput = Console.ReadLine();
        
        Console.WriteLine("Please enter the second value:");
        string secondInput = Console.ReadLine();
        
        // Print the two inputs on separate lines
        Console.WriteLine("First value: " + firstInput + "\nSecond value: " + secondInput);
    }
}
