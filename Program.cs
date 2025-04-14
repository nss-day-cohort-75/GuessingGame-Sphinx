using System.Xml.Serialization;


Random random = new Random(7);
int secretNumber = random.Next(1, 101);
int guesses = 4;
int count = 1;
while (guesses > 0)
{
    Console.WriteLine($"This is guess number {count}, you have {guesses} guesses left, Guess the secret number");
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