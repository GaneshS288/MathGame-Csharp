using MathGame;

Random random = new Random();

Menu menu = new Menu();
MathOperations mathOperations = new MathOperations();

List<string> gameRecords = new List<string>();
int recordCounter = 0;

string[] gameName = { "", "Addition", "Subtraction", "Multiplication", "Division" };
string[] mathOperators = { "", "+", "-", "*", "/" };

int index;

string? userInput;
bool isValidInput;

do
{
    
    menu.PrintGameSelection();
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



void PlayGame()
{
    while (userInput != "exit")
    {
        
        isValidInput = int.TryParse(userInput, out index);

        while (userInput != "exit")
        {
            //change bool value so inner loop can work
            isValidInput = false;

            double firstNum = random.Next(1, 11);
            double secondNum = random.Next(1, 11);
            double result = 0;

            Console.Clear();
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
                        result = mathOperations.Add(firstNum, secondNum);
                        break;

                    case "Subtraction":
                        result = mathOperations.Subtract(firstNum, secondNum);
                        break;

                    case "Multiplication":
                        result = mathOperations.Multiply(firstNum, secondNum);
                        break;

                    case "Division":
                        result = mathOperations.Divide(firstNum, secondNum);
                        break;
                }

                if (isValidInput == true && result == userAnswer)
                {
                    Console.WriteLine($"{result} was the right answer!(Press enter to continue)\n");
                    Console.ReadLine();

                    //retain index value to prevent indexOutOfRange error
                    userInput = $"{index}";

                    gameRecords.Add($"Game {recordCounter}: Problem: {firstNum} {mathOperators[index]} {secondNum}, Answer: {result}, User answer: {userAnswer} ");
                    recordCounter++;
                }

                else if (isValidInput == true && result != userAnswer)
                {
                    Console.WriteLine($"{userAnswer} is not the right answer, the right answer is {result}. (press enter to continue)\n");
                    Console.ReadLine();

                    gameRecords.Add($"Game {recordCounter}: Problem: {firstNum} {mathOperators[index]} {secondNum}, Answer: {result}, User answer: {userAnswer} ");
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




void DisplayGameRecords()
{
    Console.Clear();

    if (!gameRecords.Any())
    {
        Console.WriteLine("No more records to display(Press enter to continue)");
        Console.ReadLine();
    }

    foreach (string record in gameRecords)
    {
        Console.WriteLine(record);
        
        if (gameRecords.IndexOf(record) == (gameRecords.Count - 1)
)
        {
            Console.WriteLine("\nNo more records to display(Press enter to continue)");
            Console.ReadLine();
        }

    }
}