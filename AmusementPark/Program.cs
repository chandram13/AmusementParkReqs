// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

namespace AmusementPark
{
    class Amusement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Do you have your amusement park ticket with you? Please show your barcode.");
            double entry = Console.ReadLine();
            Console.WriteLine("You must be five feet and above to ride. Tell me your current height to ride.");
            string tallEnough = Console.ReadLine();
            Console.WriteLine("My name is " + yourName + "my barcode number is" + entry + "." + "Your barcode has been successfully scanned." + "My current height is" +
                              tallEnough + ".");
            const string welcomeMessage = "Have a great time! Make sure to stay hydrated!";
            Console.WriteLine(welcomeMessage);
        }
    }
}