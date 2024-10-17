using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Spectre.Console;


namespace BasicChallenges1;

class Program
{
    static void Main(string[] args)
    {
        Menu();
    }
    

    public static void Menu()
    {
                    Console.WriteLine("\n\tHi and Welcome to The Calculator!" +
                                      "\n\tI will ask you for two numbers that you can calculate.");
                    var number1 = AnsiConsole.Prompt(
                        new TextPrompt<int>("[green]Number 1: [/]"));
                    var number2 = AnsiConsole.Prompt(
                        new TextPrompt<int>("[red]Number 2: [/]"));
                   Func<int, int, int> Addition = (number1, number2) => number1 + number2;
                   Func<int, int, int> Subtraction = (number1, number2) => number1 - number2;
                   Func<int, int, int> Multiplication = (number1, number2) => number1 * number2;
                   Func<double, double, string> Division = (number1, number2) => number2 == 0
                       ? "Error: Division by zero is not allowed."
                       : $"The result of dividing {number1} by {number2} is {number1 / number2}";
        bool endApp = false;
        while (!endApp)
        {
            Console.Clear();
            Console.WriteLine($"\n\tThe number you chose is: {number1} and {number2}");
            var choice = AnsiConsole.Prompt(
                new SelectionPrompt<string>()
                    .Title("\n\tWhat's your [green]favorite [/]calculation?")
                    .PageSize(10)
                    .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                    .AddChoices(new[]
                    {
                        "Addition", "Subtraction", "Division",
                        "Multiplication", "Quit",
                    }));

            switch (choice)
            {
                case "Addition":
                    Console.WriteLine($"The result of adding {number1} + {number2} = {Addition(number1, number2)}");
                    Console.ReadLine();
                    break;

                case "Subtraction":
                    Console.WriteLine($"The result of subtracting {number1} - {number2} = {Subtraction(number1, number2)} ");
                    Console.ReadLine();
                    break;

                case "Division":
                    Console.WriteLine($"The result of dividing {number1} / {number2} = {Division(number1, number2)}");
                    Console.ReadLine();
                    break;

                case "Multiplication":
                    Console.WriteLine($"The result of multiplying {number1} * {number2} = {Multiplication(number1, number2)} ");
                    Console.ReadLine();
                    break;

                case "Quit":
                    Console.Clear();
                    Console.WriteLine("\n\tGoodbye!");
                    Thread.Sleep(2000);
                    endApp = true;
                    break;

            }

        }
    }

    





}



