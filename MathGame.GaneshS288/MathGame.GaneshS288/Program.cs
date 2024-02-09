Console.WriteLine("Hello there! Which Game would you like to play Today");
string? userInput;
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
    Console.WriteLine("Enter 3 to play a division game");

    Console.WriteLine("\nEnter 0 to exit");
}