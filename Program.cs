using System;
class TaxumoTaskThree
{

    public static void Main()
    {

        Console.Write("Input number of Fibonacci Series : ");
        int n = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine();
        Console.WriteLine("Fibonacci series of " + n + " number with their category");
        Console.WriteLine();

        //display the result 
        for (int i = 0; i < n; i++)
        {
            string Prime = IsPrime(GenerateFibonacci(i)) ? "Prime" : "Not Prime";
            string type = GenerateFibonacci(i) % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(GenerateFibonacci(i) + " - " + Prime + "/" + type);
        }
        Console.WriteLine();
    }

    //Genearte Fibonacci Series based on the n number and returns an int
    public static int GenerateFibonacci(int n)
    {
        int num1 = 0;
        int num2 = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp + num2;
        }
        return num1;
    }

    //check if the number is primse or not and returns a boolean
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }
}
