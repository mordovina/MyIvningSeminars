// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от
// N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());        
// PrintNum(N);

// void PrintNum(int N)
// {
//     if (N >= 1)
//     {
//     Console.Write(N + " ");
//     PrintNum (N-1);
//     } 
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите первое число: ");
// int M = Convert.ToInt32(Console.ReadLine()); 
// Console.Write("Введите второе число: ");
// int N = Convert.ToInt32(Console.ReadLine()); 

// if (M <= N)
// {
//   int sum = 0;
//   for (int i = M; i <= N; i++)
//   {
//     sum += i;
//   }
// Console.WriteLine("Сумма чисел от " + M + " до " + N + ": " + sum);
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных 
// числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int Ackerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (m > 0 && n == 0)
//     {
//         return Ackerman(m - 1, 1);
//     }
//     else
//     {
//         return Ackerman(m - 1, Ackerman(m, n - 1));
//     }
// }

// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Функция Аккермана для m = " + m + " и n = " + n + ": " + Ackerman(m, n));