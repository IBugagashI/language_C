﻿/* Треугольник Паскаля
Вывести первые n строк треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.
Ввод: 5
Вывод
1
11
121
1331
14641 */


Console.Clear();
Console.Write("Укажите число строк треугольника Паскаля: ");
int i, c;
int N = Convert.ToInt32(Console.ReadLine());
float factorial(int N)
        {
            float i, x = 1;
            for (i = 1; i <= N; i++)
            {
                x *= i;
            }
            return x;
        }

for (i = 0; i < N; i++)
            {
                for (c = 0; c <= (N - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
                {
                    Console.Write(" "); 
                }
                for (c = 0; c <= i; c++)
                {
                    Console.Write(" "); // создаём пробелы между элементами треугольника
                    Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
                }
                Console.WriteLine();
                Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
            }
            Console.ReadLine();