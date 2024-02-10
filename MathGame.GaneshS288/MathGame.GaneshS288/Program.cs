Random random = new Random();

string[] gameRecords = new string[100];
int recordCounter = 0;

string? userInput;
bool isValidInput;

do
{
    Console.WriteLine("Hello there! Which Game would you like to play Today?\n");
    PrintGameSelection();
    userInput = Console.ReadLine()?.Trim();

    int checkInput;
    isValidInput = int.TryParse(userInput, out checkInput);

    if (userInput == "0")
        break;

    else if (userInput == "5")
        DisplayGameRecords();

    else if (checkInput > 1 && checkInput > 4 || isValidInput == false)
    {
        Console.WriteLine("Please enter a valid value");
        Console.ReadLine();
    }

    else
        PlayGame();
}
while (userInput != "0");

void PrintGameSelection()
{
    Console.WriteLine("Enter 1 to play an addition game");
    Console.WriteLine("Enter 2 to play a subtraction game");
    Console.WriteLine("Enter 3 to play a multiplication game");
    Console.WriteLine("Enter 4 to play a division game");
    Console.WriteLine("Enter 5 to see previous game records");

    Console.WriteLine("\nEnter 0 to exit");
}

void PlayGame()
{
    while (userInput != "exit")
    {
        string[] gameName = { "", "Addition", "Subtraction", "Multiplication", "Division" };
        string[] mathOperators = { "", "+", "-", "*", "/" };

        int index;
        isValidInput = int.TryParse(userInput, out index);

        while (userInput != "exit")
        {
            //change bool value so inner loop can work
            isValidInput = false;

            double firstNum = random.Next(1, 11);
            double secondNum = random.Next(1, 11);
            double result = 0;


            Console.WriteLine($"{gameName[index]} Game");
            Console.WriteLine($"{firstNum} {mathOperators[index]} {secondNum}");
            Console.WriteLine($"Enter your answer below. Answer should be accurate up to 2 decimal places.\n (type exit to go back to selection screen)");

            while (isValidInput != true)
            {

                userInput = Console.ReadLine()?.Trim().ToLower();

                double userAnswer;
                isValidInput = double.TryParse(userInput, out userAnswer);

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

                if (isValidInput == true && result == userAnswer)
                {
                    Console.WriteLine($"{result} was the right answer!(Press enter to continue)\n");
                    Console.ReadLine();
                    //retain index value to prevent indexOutOfRange error
                    userInput = $"{index}";
                    gameRecords[recordCounter] = $"Game {recordCounter}: Problem: {firstNum} {mathOperators[index]} {secondNum}, Answer: {result}, User answer: {userAnswer} ";
                    recordCounter++;
                }

                else if (isValidInput == true && result != userAnswer)
                {
                    Console.WriteLine($"{userAnswer} is not the right answer, the right answer is {result}. (press enter to continue)\n");
                    Console.ReadLine();
                    gameRecords[recordCounter] = $"Game {recordCounter}: Problem: {firstNum} {mathOperators[index]} {secondNum}, Answer: {result}, User answer: {userAnswer} ";
                    recordCounter++;
                }

                else if (userInput == "exit")
                    break;


                else
                    Console.WriteLine("Please enter a valid value.(or type exit to go back)");

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
    result = double.Truncate(result * 100) / 100;
    return result;
}

void DisplayGameRecords()
{
    foreach (string record in gameRecords)
    {
        Console.WriteLine(record);
        if (record == null)
        {
            Console.WriteLine("No more records to display(Press enter to continue)");
            Console.ReadLine();
            break;
        }

    }
}