string cardNum = "123456789";
string cashMoney = "1000";
string pinnCode = "1234";


Console.WriteLine(" please enter the card number");
string currentcardNumber = Console.ReadLine();

Console.WriteLine("please enter your pinn code");
string currentPinn = Console.ReadLine();

if (cardNum == currentcardNumber && pinnCode ==currentPinn)
{

    Console.WriteLine("logged into your account");
    Console.BackgroundColor = ConsoleColor.Green;

}
else
{
    if (cardNum!=currentcardNumber)
    {
  
        Console.WriteLine("card number is incorret");
        Console.BackgroundColor = ConsoleColor.Red;
    }


    else if (pinnCode!=currentPinn)
    {
       
        Console.WriteLine("pinn code is incorret");
        Console.BackgroundColor = ConsoleColor.Red;
    }
}
