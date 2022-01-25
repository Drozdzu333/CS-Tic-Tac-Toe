
using Tic_Tac_Toe;

// Hello
Console.WriteLine("Hello, World!\nWelcome to console game Tic Tac Toe developed by Michał Rożdżyński");
Console.WriteLine("This game is stering by coordinates writen in to the console.");

// Variables
string[] basicMarks = new string[] { ".", ".", ".", ".", ".", ".", ".", ".", "." };
string PlayerX;
string PlayerO;
bool correct = false;


var class1 = new Board(_ = basicMarks);


// Checker for first player input.
do
{
    Console.WriteLine("Choose square from A1 to C3 for mark X -_first player_-.");
    PlayerX = Console.ReadLine();

    int foo = 0;
    int bar = 0;
    if (PlayerX == null || PlayerX.Length != 2)
    {
        correct = false;
    }
    else
    {
        foo = PlayerX[0] - '0';
        bar = PlayerX[1] - '0';

    }
    switch(foo, bar){
        case (17, 1):
            Console.WriteLine("A1");
            correct = true;
            break;
        case (17, 2):
            Console.WriteLine("A2");
            correct = true;
            break;
        case (17, 3):
            Console.WriteLine("A3");
            correct = true;
            break;

        case (18, 1):

            break;

        case (19, 1):

            break;

        default:
            correct = false;
            break;
        
    }
} while (correct == false);


    //PlayerX = Console.ReadLine();
    //double foo = Char.GetNumericValue(PlayerX[0]);
    //Console.WriteLine($"PlaverX = {PlayerX} and Playerx[0] = {PlayerX[0]} and conversion result is ={1<=foo && foo<=3 }");

Console.WriteLine("Choose square for mark O -  second player.");
PlayerO = Console.ReadLine();   
