using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_Factorial
{
    class Program
    {
        // ВЫЧИСЛЕНИЕ ФАКТОРИАЛА
        public static long GetFact(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            return i * GetFact(i - 1);
        }
        static void Main(string[] args)
        {
            // ВВОЖУ ЧИСЛО С КЛАВИАТУРЫ
            Console.WriteLine("Введите ЦЕЛОЕ число - ");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("вы ввели число = " + myNum); // ПРОВЕРКА ВВОДА

            // ВЫЗЫВАЮ ФУНКЦИЮ ВЫЧИСЛЕНИЕ ФАКТОРИАЛА
            long myFact = GetFact(myNum);

            // ВЫВОЖУ РЕЗУЛЬТАТ НА КОНСОЛЬ
            // ДЕЛАЮ ИНТЕРПОЛЯЦИЮ СТРОК
            Console.WriteLine($"Факториал из числа {myNum} равен = {myFact}");

            Console.ReadKey();
        }
    }
}
