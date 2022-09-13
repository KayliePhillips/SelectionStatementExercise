//Create a program that allows a user to play a game
//where they must guess what your favorite number is:

var r = new Random();
var favNumber = r.Next(1, 1000);

//var favNumber = 45;  //this was a test to see if the code would work so I know what number is my favorite and not a random number
Console.WriteLine("Welcome to the number guessing game.  Can you guess my favorite number?");
var userInput = int.Parse(Console.ReadLine());

while (userInput != favNumber)
{
    if (userInput < favNumber)
    {
        Console.WriteLine("Too low. Guess again");
        userInput = int.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Too high. Guess again");
        userInput = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("Great Job! You guessed my favorite number.");