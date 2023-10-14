using System;

public class Program
{
    public static void Main(string[] args)
    {
            double a;
            double b;
            double total;
            char oper;

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

            else if (oper == '/')
            {
                total = a / b;
                Console.WriteLine(a + "/" + b + "=" + total);
            }
            else
            {
                Console.WriteLine("Unknown operator");
            } 
    }
}