using RPS;

bool playAgain = true;
string userChoice;
string computerChoice;
string answer;

Dictionary<string, string> options = new() { { "r" , "Rock" }, { "p" , "Paper" }, { "s" , "Scissors" } };

while (playAgain)
{
    userChoice = string.Empty;

    while (userChoice != "r" && userChoice != "p" && userChoice != "s")
    {
        Console.WriteLine("Choose between rock (r), paper (p), scissors (s)");
        userChoice = Console.ReadLine()!;
    }

    Computer computer = new();
    computerChoice = computer.MakeChoice();

    Console.WriteLine("User: " + options[userChoice]);
    Console.WriteLine("Comp: " + options[computerChoice]);

    Result result = new();
    result.DetermineOutput(userChoice, computerChoice);

    Console.WriteLine("Would you like to play again? (Y/N)");
    answer = Console.ReadLine()!;

    if(answer == "Y")
    {
        playAgain = true;
    }
    else
    {
        playAgain = false;
        Console.WriteLine("Thank you for playing");
    }
}
                     
