using Guessing;

GuessingCore guess = new();

Console.WriteLine("Hello, World!");
Console.WriteLine("Guess number between 1 and 100");
Console.WriteLine("-1 to leave");

int guessRes;
string guessMessage;
while (true) { 
    string numb = Console.ReadLine();
    int num = 0;
    if(!Int32.TryParse(numb, out num ))
    {
        continue;
    }

    if (num == -1)
    {
        break;
    }

    guessRes = guess.guess(num);

    switch (guessRes)
    {
        case 0:
            guessMessage = "Correct";
            break;
        case 1:
            guessMessage = "guessed too low";
            break;
        case -1:
            guessMessage = "guessed too high";
            break;
        default:
            guessMessage = "error";
            break;
    }

    Console.WriteLine("Attempt: " + guess.attempts + ": " + guessMessage);
    if (guessRes == 0) 
    {
        break;
    }
}