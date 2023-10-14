using System;

public class Program
{
    public static void Main(string[] args)
    {
        char again = 'Y';
        while(again=='Y')
        {
            double a;
            double b;
            double total;
            char oper;
            Console.WriteLine("Hi! This is calculator that made Igor Fomin.");
            Console.WriteLine("Input first operand:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Input operator:");
            oper = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Input second operand:");
            b = Convert.ToDouble(Console.ReadLine());

            if (oper == '+')
            {
                total = a + b;
                Console.WriteLine(a + "+" + b + "=" + total);
            }

            else if (oper == '-')
            {
                total = a - b;
                Console.WriteLine(a + "-" + b + "=" + total);
            }

            else if (oper == '*')
            {
                total = a * b;
                Console.WriteLine(a + "*" + b + "=" + total);
            }

            else if (oper == '/' && b != 0.0)
            {
                total = a / b;
                Console.WriteLine(a + "/" + b + "=" + total);
            }
            else if (oper == '/' && b == 0)
            {
                Console.WriteLine("Second operator is 0. It's ERROR!");
            }
            else
            {
                Console.WriteLine("Unknown operator");
            }
            Console.WriteLine("Are you want repeat your experience? (Y/N)");
            again = Convert.ToChar(Console.ReadLine());
        }    
    }
}