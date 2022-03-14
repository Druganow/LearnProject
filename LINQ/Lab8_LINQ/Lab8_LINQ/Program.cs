using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1)Палиндромы в отрезке (От 100 до 999)");
            foreach (var i in Queries.Task1(100, 999))
                Console.WriteLine(i);

            Console.WriteLine("\n2)Сумма цифр введённого числа\n" + Queries.Task2(1234));

            Console.WriteLine("\n3)Количество вхождений цифры в число\n" + Queries.Task3(123114, 1));

            Console.WriteLine("\n4)Проверка числа на простоту\n" + Queries.Task4(5));

            Console.WriteLine("\n5)Простые чисел в отрезке [2;30]");
            foreach (var i in Queries.Task5(2, 30))
                Console.WriteLine(i);

            Console.WriteLine("\n6)Числа с наибольшим количеством делителей в отрезке [2;10]");
            foreach (var i in Queries.Task6(2, 30))
                Console.WriteLine(i);

            Console.WriteLine("\n7)Сортировка массива чисел( 107, 9, 331, 17): ");
            foreach (var i in Queries.Task7(new int[] { 107, 9, 331, 17 }))
                Console.WriteLine(i);

            Console.WriteLine("\n8)Удаление цифр из строки(a 123b): " + Queries.Task8("a 123b"));

            Console.WriteLine("\n9)Количество различных элементов в массиве( 1, 2, 3, 4, 1, 2, 3, 4 ): " + Queries.Task9(new int[] { 1, 2, 3, 4, 1, 2, 3, 4 }));

            Console.ReadKey();

        }
    }

        
}