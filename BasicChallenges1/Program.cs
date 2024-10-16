using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Spectre.Console;


namespace BasicChallenges1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");
        Menu();
    }
    

    public static void Menu()
    {
        
        var choice = AnsiConsole.Prompt(
                    new SelectionPrompt<string>()
                        .Title("What's your [green]favorite [/]calculator?")
                        .PageSize(10)
                        .MoreChoicesText("[grey](Move up and down to reveal more options)[/]")
                        .AddChoices(new[] {
                            "Addition", "Subtraction", "Division", 
                            "Multiplication", "Quit",
                        }));
        var number1 = AnsiConsole.Prompt(
            new TextPrompt<int>("Give me a [green]number [/]"));
        var number2 = AnsiConsole.Prompt(
            new TextPrompt<int>("Give me another [red]number [/]"));
        switch (choice)
        {
            case "Addition":
                Addition(number1, number2);
                break;
            
            case"Subtraction":
                Subtraction(number1, number2);
                break;
            
            case "Division":
                Division(number1, number2);
                break;
            
            case "Multiplication":
                Multiplication(number1, number2);
                break;
            
            case "Quit":
                break;
            
            
        }
        
        
    }

    private static void Multiplication(int number1, int number2)
    {
        throw new NotImplementedException();
    }

    private static void Division(int number1, int number2)
    {
        throw new NotImplementedException();
    }

    private static void Subtraction(int number1, int number2)
    {
        throw new NotImplementedException();
    }

    private static void Addition(int number1, int number2)
    {
        Console.WriteLine(number1 + number2);
    }





}



