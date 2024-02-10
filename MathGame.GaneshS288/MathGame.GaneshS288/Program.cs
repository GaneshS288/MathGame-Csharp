﻿Random random = new Random();


string? userInput;
bool isValidinput;

do
{
    Console.WriteLine("Hello there! Which Game would you like to play Today?");
    PrintGameSelection();
    userInput = Console.ReadLine().Trim();
    PlayGame();
    

    
}
while (userInput != "0");

void PrintGameSelection()
{
    Console.WriteLine("Enter 1 to play an addition game");
    Console.WriteLine("Enter 2 to play a subtraction game");
    Console.WriteLine("Enter 3 to play a multiplication game");
    Console.WriteLine("Enter 4 to play a division game");

    Console.WriteLine("\nEnter 0 to exit");
}

void PlayGame()
{
    while (userInput != "exit")
    {
        string[] gameName = { "", "Addition", "Subtraction", "Multiplication", "Division" };
        string[] mathOperators = { "", "+", "-", "*", "/" };

        int index;
        isValidinput = int.TryParse(userInput, out index);
        isValidinput = false;

        while (isValidinput != true)
        {

            double firstNum = random.Next(1, 11);
            double secondNum = random.Next(1, 11);
            double result = 0;


            Console.WriteLine($"{gameName[index]} Game");
            Console.WriteLine($"{firstNum} {mathOperators[index]} {secondNum}");
            Console.WriteLine($"Enter your answer Below");

            userInput = Console.ReadLine();

            double userAnswer;
            isValidinput = double.TryParse(userInput, out userAnswer);

            switch (gameName[index])
            {
                case "Addition":
                    result = Add(firstNum, secondNum);
                    break;

                case "Subtraction":
                    result = Subtract(firstNum, secondNum);
                    break;

                case "Multiplication":
                    result = Multiply(firstNum, secondNum);
                    break;

                case "Division":
                    result = Divide(firstNum, secondNum);
                    break;
            }

            if (isValidinput == true && result == userAnswer)
            {
                Console.WriteLine($"{result} was the right answer!");
                //retain index value to prevent indexOutOfRange error
                userInput = $"{index}";
            }

            else if (isValidinput == true && result != userAnswer)
            {
                Console.WriteLine($"{userAnswer} is not the right answer, the right answer is {result}");
                isValidinput = false;
            }

            else
            {
                Console.WriteLine("Please enter a valid value");
            }
        }
    }
}


double Add(double firstNum, double secondNum)
{

    double result = firstNum + secondNum;
    return result;
}

double Subtract(double firstNum, double secondNum)
{
    double result = firstNum - secondNum;
    return result;
}

double Multiply(double firstNum, double secondNum)
{
    double result = firstNum * secondNum;
    return result;
}

double Divide(double firstNum, double secondNum)
{
    double result = firstNum / secondNum;
    return result;
}