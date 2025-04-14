using System.Xml.Serialization;

int secretNumber = 42;
int guesses = 4;
int count = 1;
while (guesses > 0)
{
    Console.WriteLine($"This is guess number {count}, Guess the secret number");
    int choice = int.Parse(Console.ReadLine().Trim());
    count++;
    if (secretNumber == choice)
    {
        Console.WriteLine($"{choice} was the secret number!");
        break;
    }
    else
    {
        Console.WriteLine($"{choice} was not the secret number.");
        guesses--;
    }
}