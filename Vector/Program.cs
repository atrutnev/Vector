using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Vector
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                //Шапка
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine((new string('=', 79)));
                Console.WriteLine("\t\t\tПрограмма векторных операций");
                Console.WriteLine((new string('=', 79)));
                
                //Вызов генератора векторов и формирование двух списков: обычного и отсортированного с выводом каждого на экран
                var g = new Generator<int>();
                var sortedList = g.OrderBy(o => o.length).ToList();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Список сгенерированных векторов:");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var v in g)
                    {
                        Console.WriteLine(v);
                    }
                    Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Отсортированный список векторов по длине в порядке возрастания: ");
                Console.ForegroundColor = ConsoleColor.White;
                foreach (var s in sortedList)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("");

                //Случайный выбор двух векторов из списка для выполнения операций над ними
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Выбор двух векторов из списка для операций над ними: ");
                var takeVector = g.ToList();
                int indexFirstVector;
                int indexSecondVector;
                Random rnd = new Random();
                indexFirstVector = rnd.Next(0, takeVector.Count());
                //Цикл "do - while" добавлен для исключения случайного выбора одного и того же вектора
                //Однако в этом случае практически невозможно добиться равенства векторов
                do
                {
                    indexSecondVector = rnd.Next(0, takeVector.Count());
                }   while (indexSecondVector == indexFirstVector);
                Vector<int> firstVector = takeVector[indexFirstVector];
                Vector<int> secondVector = takeVector[indexSecondVector];
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0},\n{1}\n", firstVector, secondVector);

                //Вывод на экран суммы векторов
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Сумма векторов {0} и {1} (вектор P): ", firstVector.nameVector, secondVector.nameVector);
                Vector<int> P = firstVector + secondVector;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\n", P);

                //Вывод на экран разности векторов
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Разность векторов {0} и {1} (вектор M): ", firstVector.nameVector, secondVector.nameVector);
                Vector<int> M = firstVector - secondVector;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("{0}\n", M);

                //Вывод на экран результата сравнения векторов
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Сравнение векторов {0} и {1}: ", firstVector.nameVector, secondVector.nameVector);
                Console.ForegroundColor = ConsoleColor.White;
                if (firstVector != secondVector == true)
                {
                    if (firstVector > secondVector == true)
                    {
                        Console.WriteLine("Вектор {0} больше вектора {1}\n", firstVector.nameVector, secondVector.nameVector);
                    }
                    else
                    {
                        Console.WriteLine("Вектор {0} меньше вектора {1}\n", firstVector.nameVector, secondVector.nameVector);
                    }
                }
                else
                {
                    Console.WriteLine("Вектора {0} и {1} равны\n", firstVector.nameVector, secondVector.nameVector);
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Нажмите любую клавишу для повторного запуска программы ...");
                Console.ReadKey();
            }
        }     
    }
}
