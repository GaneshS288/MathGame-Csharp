using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame;

internal class Menu
{
    internal string[] gameName = { "", "Addition", "Subtraction", "Multiplication", "Division" };
    internal string[] mathOperators = { "", "+", "-", "*", "/" };

    internal void PrintGameSelection()
    {
        Console.Clear();
        Console.WriteLine("Hello there! Which Game would you like to play Today?\n");
        Console.WriteLine("Enter 1 to play an addition game");
        Console.WriteLine("Enter 2 to play a subtraction game");
        Console.WriteLine("Enter 3 to play a multiplication game");
        Console.WriteLine("Enter 4 to play a division game");
        Console.WriteLine("Enter 5 to see previous game records");

        Console.WriteLine("\nEnter 0 to exit");
    }

    internal void PrintCurrentGame(double firstNum, double secondNum, int index)
    {
        Console.Clear();
        Console.WriteLine($"{gameName[index]} Game");
        Console.WriteLine($"{firstNum} {mathOperators[index]} {secondNum}");
        Console.WriteLine($"Enter your answer below.\n (type exit to go back to selection screen)");
    }
}
