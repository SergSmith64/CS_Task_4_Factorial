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
        static int GetFact(int i)
		{
			int result;
			// Факториал от НУЛЯ равен ЕДИНИЦЫ (принимается в качестве соглашения)
			if (i == 0) return 1;
			if (i == 1) return 1;
			result = GetFact(i - 1) * i;
			return result;
		}
        public void CheckInput()
        {
            int i;
            // ВВОЖУ ЧИСЛО С КЛАВИАТУРЫ
            Console.WriteLine("\nВведите ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ число : ");
            try
            {
                i = int.Parse(Console.ReadLine());
                if (i >= 0)
                {
                    if (i <= 16)
                    {
                        Console.WriteLine("Факториал из {0}! = {1}", i, GetFact(i));
                    }
                    else
                    {
                        // _______ ЗДЕСЬ Я ДУМАЮ ВОЗНИКАЕТ ПЕРЕПОЛНЕНИЕ ПАМЯТИ _____________________________________________________
                        Console.WriteLine("Факториал БОЛЬШЕ 16 вызывает переполнение памяти. Пожалуйста введите число от 0 до 16! ");
                        CheckInput();
                    }
                    
                } 
                else
                {
                    Console.WriteLine("Вы ввели НЕкорректное число. Пожалуйста повторите! ");
                    CheckInput();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели НЕ число. Пожалуйста повторите! ");
                CheckInput();
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели НЕкорректное число. Пожалуйста повторите! ");
                CheckInput();
            }
        }
        static void Main(string[] args)
		{
            Program f1 = new Program();
            f1.CheckInput();
            Console.ReadKey();
		}
	}
}