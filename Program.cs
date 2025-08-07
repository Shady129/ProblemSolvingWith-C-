





Console.WriteLine("Welcome to compare 3 numbers");
double fNumber = 0, sNumber = 0, tNumber = 0;




fNumber = ReadNumer("Please enter the first number: ");

sNumber = ReadNumer("Please enter the second number: ");

tNumber = ReadNumer("Please enter the third number: ");



if (fNumber > sNumber && fNumber > tNumber)
{
    Console.WriteLine("first number is winner " + fNumber);
}

else if(sNumber > fNumber && sNumber > tNumber)
{
    Console.WriteLine("second number is the winner " + sNumber);

}

else if(tNumber > fNumber && tNumber > sNumber)
{
    Console.WriteLine("third number is winner " + tNumber);
}
else
{
    Console.WriteLine("There is a tie between two or more highest numbers.");
}



double ReadNumer(string message)
{

    double Number;
    while (true)
    {

        Console.WriteLine(message);
        bool IsValidNumber = double.TryParse(Console.ReadLine(), out Number);

        if (IsValidNumber)
        {
            return Number;

        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }


    }


}