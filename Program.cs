using System.Xml.Serialization;

int secretNumber = 42;
int guesses = 4;
while(guesses > 0){
    Console.WriteLine("Guess the secret number");
    int choice = int.Parse(Console.ReadLine().Trim());
    if(secretNumber == choice){
        Console.WriteLine($"{choice} was the secret number!");
        break;
    }else{
        Console.WriteLine($"{choice} was not the secret number.");
        guesses--;
    }
}