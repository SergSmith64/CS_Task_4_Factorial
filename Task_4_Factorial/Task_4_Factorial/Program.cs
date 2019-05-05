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
            static void Main(string[] args)
            {
                int i;
                label1:
                // ВВОЖУ ЧИСЛО С КЛАВИАТУРЫ
                Console.WriteLine("Введите ЦЕЛОЕ ПОЛОЖИТЕЛЬНОЕ число : ");
     
                try 
                {
                i = int.Parse(Console.ReadLine());
                    if (i < 0)
                    {
                        throw new Exception("вы ввели отрициательное число");
                    }
                    else 
                    {
                    Console.WriteLine("Факториал из {0}! = {1}", i, GetFact(i));
                    }
                    
                }
                catch(FormatException)
                {
                    Console.WriteLine("Вы ввели НЕ число. Пожалуйста повторите! ");
                    goto label1;
                }
                catch(Exception) 
                {
                    Console.WriteLine("Вы ввели отрицательное число. Пожалуйста повторите! ");
                    goto label1;
                }
     
                Console.ReadKey();
            }
        }
    }