using System;

namespace Console_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Double number1;
            Double number2;
            string operation;

            Console.WriteLine("Wtite Number 1");

            number1 = double.Parse(Console.ReadLine());  

            Console.WriteLine(" Write Operation + - * / ");

            operation = Console.ReadLine();
            
            switch (operation)
            {
                case "+":
                    Console.WriteLine("Write Number 2");

                    number2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(number1 + number2);
                    break;

                   
                case "-":
                    Console.WriteLine("Write Number 2");
                    
                    number2 = double.Parse(Console.ReadLine());

                    Console.WriteLine(number1 - number2);
                    break;

                case "*":
                    Console.WriteLine("Write Number 2");
                    
                    number2 = double.Parse(Console.ReadLine());
                    Console.WriteLine(number1 * number2);
                    break;

                case "/" :
                    
                    Console.WriteLine("Write Number 2");
                    
                    number2 = double.Parse(Console.ReadLine());
                    if (number2 == 0)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine(number1 / number2);
                    }
                    break;
                default:
                    Console.WriteLine("ERRoR");
                    break;
            }   

            Console.ReadLine();

        }
    }   
}
