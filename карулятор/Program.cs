using System;


namespace каркулятор
{
    class Program
    {    
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstValue, secondValue;
                string action;

                Console.WriteLine("Введите число 1");
                firstValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Введите число 2");
                secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Выберите операцию:'+' '-' '*' '/'");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firstValue + secondValue);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstValue - secondValue);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstValue * secondValue);
                }
                else if (action == "/")
                {
                    if (secondValue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstValue / secondValue);
                }
                else
                {
                    Console.WriteLine("Ошибка! неизвестное действие!");
                }

                Console.ReadLine();
            }
            
        }
    }
}
