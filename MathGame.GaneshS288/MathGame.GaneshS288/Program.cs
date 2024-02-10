Console.WriteLine("Hello there! Which Game would you like to play Today?");
string? userInput;
bool? isValidinput;
do
{
    PrintGameSelection();
    userInput = Console.ReadLine();

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

void PlayGame(string input)
{
    do
    {
        string[] selectionChoices = { "0", "1", "2", "3", "4" };
        string[] gameNames = { "Exit", "Addition", "Subtraction", "Multiplication", "Division" };

        Random random = new Random();

        int firstNum = random.Next(1, 101);
        int secondNum = random.Next(1, 101);

        userInput = Console.ReadLine().Trim();
        int userAnswer = 0;

        isValidinput = int.TryParse(userInput, out userAnswer);
    } while (userInput != "0");
}

int Add(int firstNum, int secondNum)
{
    
    int result = firstNum + secondNum;
    return result;
}

int Subtract(int firstNum, int secondNum)
{
    int result = firstNum - secondNum;
    return result;
}

int Multiply(int firstNum, int secondNum)
{
    int result = firstNum * secondNum;
    return result;
}

int Divide(int firstNum, int secondNum)
{
    int result = firstNum / secondNum;
    return result;
}