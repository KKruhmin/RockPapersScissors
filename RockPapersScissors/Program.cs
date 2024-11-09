Random random = new Random();
bool playAgain = true;
string answer = "";
string[] moves = { "rock", "paper", "scissors" };

Console.WriteLine("\nLETS PLAY ROCK PAPER SCISSORS!\n\nMoves: Rock, Paper, or Scissors\n");

while (playAgain)
{
    string computerMove = moves[random.Next(moves.Length)];
    Console.WriteLine("ENTER YOUR MOVE:\n");
    string playersMove = Console.ReadLine().ToLower();

    if (validate(playersMove))
    {
        displayAsciiArt(playersMove);

        Console.WriteLine("COMPUTER MOVE: \n");
        displayAsciiArt(computerMove);

        switch (playersMove)
        {
            case "rock":

                if (computerMove == "scissors")
                {
                    Console.WriteLine("YOU WIN!\n");
                }
                else if (computerMove == "paper")
                {
                    Console.WriteLine("YOU LOSE!\n");
                }
                else
                {
                    Console.WriteLine("TIE!\n");
                }
                break;

            case "paper":

                if (computerMove == "rock")
                {
                    Console.WriteLine("YOU WIN!\n");
                }
                else if (computerMove == "scissors")
                {
                    Console.WriteLine("YOU LOSE!\n");
                }
                else
                {
                    Console.WriteLine("TIE!\n");
                }

                break;

            case "scissors":

                if (computerMove == "rock")
                {
                    Console.WriteLine("YOU LOSE!\n");
                }
                else if (computerMove == "paper")
                {
                    Console.WriteLine("YOU WIN!\n");
                }

                break;
        }

        Console.WriteLine("Do you want to play again? Y/N");
        answer = Console.ReadLine().ToUpper();

        if (answer == "Y")
        {
            playAgain = true;
        }

        if (answer == "N")
        {
            playAgain = false;
            Console.Write("\nThanks for playing!");
        }
    }
    else
    {
        Console.WriteLine("Thats not a move, try again.\n");
    }
}
 

void displayAsciiArt(string move)
{
    const string rockAsciiArt = "    _______\r\n---'   ____)\r\n      (_____)\r\n      (_____)\r\n      (____)\r\n---.__(___)\n";
    const string scissorsAsciiArt = "    _______\r\n---'   ____)____\r\n          ______)\r\n        __________)\r\n      (____)\r\n---.__(___)\n";
    const string paperAsciiArt = "    _______\r\n---'   ____)____\r\n          ______)\r\n          _______)\r\n          _______)\r\n---.__________)\n";

    if (move == "rock")
    {
        Console.WriteLine(move.Replace(move, rockAsciiArt));
    }
    else if (move == "paper")
    {
        Console.WriteLine(move.Replace(move, paperAsciiArt));
    }
    else if (move == "scissors")
    {
        Console.WriteLine(move.Replace(move, scissorsAsciiArt));
    }
    // Tells user which move (now translated into ascii) is in play in all caps.
    Console.WriteLine(move.ToUpper() + "!\n");
}

bool validate(string move)
{
    bool valid = false;
    if (move == "rock" || move == "paper" || move == "scissors")
    {
        valid = true;
    }
    return valid;
}

Console.ReadKey();