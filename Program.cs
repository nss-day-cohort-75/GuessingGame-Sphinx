using System.Xml.Serialization;


Random random = new Random();
int secretNumber = random.Next(1, 101);
int guesses = 0;
int count = 1;

Console.WriteLine(@"Which difficulty would you like to select?
1. Easy (8 Guesses)
2. Medium (6 Guesses)
3. Hard (4 Guesses)
4. Cheater (Unlimited Guesses)
");

int response = int.Parse(Console.ReadLine().Trim());

switch (response)
{
    case (1):
        guesses = 8;
        break;

    case (2):
        guesses = 6;
        break;

    case (3):
        guesses = 4;
        break;

    case (4):
        guesses = -1;
        break;
}
string message = $"you have {guesses} guesses left, ";

if (guesses < 0) {
    message = "";
}

while (guesses != 0)
{
    Console.WriteLine($"This is guess number {count}, {message}Guess the secret number");
    int choice = int.Parse(Console.ReadLine().Trim());
    count++;
    if (secretNumber == choice)
    {
        Console.WriteLine($"{choice} was the secret number!");
        break;
    }
    else
    {
        if (choice > secretNumber)
        {
            Console.WriteLine("Too high, guess lower");
        }
        else
        {
            Console.WriteLine("Too Low, guess higher");
        }

        Console.WriteLine($"{choice} was not the secret number.");
        guesses--;
    }
}