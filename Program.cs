using System;



class TerminalCalcS
{
    static void Main(string []args)
    {
        Calculator terminalCalc_S = new Calculator();
        terminalCalc_S.System();
    }

}


class Calculator
{
    int Addition(int na, int na2)
    {
        return na + na2;
    }

    int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    int Division(int num1, int num2)
    {
        return num1 / num2;
    }



    public void System()
    {
        int num1 = 0;
        int num2 = 0;


        while (true)
        {
            Console.WriteLine("Welcome to TerminalCalc-S");
            Console.WriteLine("---------------------------|");

            Console.Write("Enter your number, and press enter: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Type another number, and press enter: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an option: | Addition | Subtraction | Multiplication | Division |");
            Console.WriteLine("Your option?");
            Console.WriteLine("Type: a, s, m, d");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + Addition(num1, num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + Subtraction(num1, num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + Multiplication(num1, num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + Division(num1, num2));
                    break;
            }
            Console.WriteLine("Type stop to close the console, enter or any key to continue...");
            if (Console.ReadLine() == "stop")
            {
                break;
            }

            Console.WriteLine("Press any key to close!");
        }
    }
}