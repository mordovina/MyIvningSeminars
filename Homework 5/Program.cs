// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// using System;
// class Program
// {
//     static void Main()
//     {
//         int[] numbers = new int[] { 345, 897, 568, 234 };
//         int even_count = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] % 2 == 0)
//                 even_count++;
//         }
//         Console.WriteLine("Количество четных чисел: " + even_count);
//     }
// }

// using System;
// class Program
// {
//     static void Main()
//     {
//         Random rand = new Random();
//         int[] numbers = new int[4];
//         int even_count = 0;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             numbers[i] = rand.Next(100, 1000);
//             if (numbers[i] % 2 == 0)
//                 even_count++;
//         }
//         Console.WriteLine("Количество четных чисел: " + even_count);
//     }
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// using System;

// class Program 
// {
//     static void Main() 
//     {
//     int[] array = {3, 7, 23, 12};
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//     if (i % 2 != 0) 
//     {
//         sum += array[i];
//     }
//     }
//         Console.WriteLine(+ sum);
//     }
// }

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
//  элементом массива.
// [3 7 22 2 78] -> 76

// double[] numbers = {3, 7, 22, 2, 78 };
// double min = numbers.Min();
// double max = numbers.Max();
// double difference = max - min;
// Console.WriteLine( + difference);

