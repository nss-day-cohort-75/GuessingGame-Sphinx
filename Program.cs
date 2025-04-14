using System.Xml.Serialization;

Console.WriteLine("Guess the secret number");
int choice = int.Parse(Console.ReadLine().Trim());
int secretNumber = 42;
if(secretNumber == choice){
    Console.WriteLine($"{choice} was the secret number!");
}else{
    Console.WriteLine($"{choice} was not the secret number.");
}