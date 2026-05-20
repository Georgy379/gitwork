using System;

namespace HelloApp
{
class Program
{
static void Main(string[] args)
{
    Console.Write("Введите своё имя");
    string name = Console.ReadLine();   //ConsoleApp1
        Console.WriteLine($"Привет {name}"); //ConsoleApp1
        Console.WriteLine($"Очень рады вас видеть!!!");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i);
        }
        i = i*3
        Console.ReadKey();
        }
    }
}