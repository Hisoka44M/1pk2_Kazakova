using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_07_01
{
    //Передача по значению: Напишите метод, который принимает два целых числа и меняет их 
    // местами. Проверьте, изменились ли значения переменных вне метода
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа X и N");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            TheNumberMethod(num1, num2);
            Console.WriteLine($"После вызова метода: X = {num1}, N = {num2}"); // изменилось только в методе
        }

        static void TheNumberMethod(int x, int n)
        {
            int vary = x;
            x = n;
            n = vary;

        }

    }
}
