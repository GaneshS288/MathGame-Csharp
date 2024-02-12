using MathGame;

Menu menu = new Menu();
GameEngine gameEngine = new GameEngine();

List<string> gameRecords = new List<string>();

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
        gameEngine.DisplayGameRecords();

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
            userInput = gameEngine.PlayGame(userInput, index);
        }
    }
}




