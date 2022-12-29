using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Class1
{
    static void Main(string[] args)
    {
        double a = 0;
        char oper = ' ';
        double b = 0;
        double total = 0;

        Console.WriteLine("Введите первое число:");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите оператор:");
        oper = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());


        if (oper == '+')
        {
            total = a + b;
            Console.WriteLine("Cумма " + a + " и " + b + " равна " + total + ".");
        }

        else if (oper == '-')
        {
            total = a - b;
            Console.WriteLine("" + total + ".");
        }

        else if (oper == '*')
        {
            total = a * b;
            Console.WriteLine("Умножение " + a + " на " + b + " равно " + total + ".");
        }

        else if (oper == '/')
        {
            total = a / b;
            Console.WriteLine("Деление " + a + " на " + b + " равно " + total + ".");
        }
        else
        {
            Console.WriteLine("Неизвестный оператор.");
        }
 
    }
}

