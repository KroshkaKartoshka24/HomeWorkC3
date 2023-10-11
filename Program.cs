// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// System.Console.WriteLine("Введите размер массива ");
// int a = Convert.ToInt32(System.Console.ReadLine());
// int[] rndArr = new int[a];
// int ch = 0;
// for (int i = 0; i < a; i++)
// {
//     rndArr[i] = new Random().Next(100,999);
//     Console.Write(rndArr[i] + " ");
//     if (rndArr[i]%2 == 0)
//     {
//         ch++;
//     }
// }
// Console.WriteLine($"\nКоличество четных чисел в массиве = {ch}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// System.Console.WriteLine("Введите размер массива ");
// int a = Convert.ToInt32(System.Console.ReadLine());
// int[] rndArr = new int[a];
// int nech = 0;
// for (int i = 0; i < a; i++)
// {
//     rndArr[i] = new Random().Next(1,9);
//     Console.Write(rndArr[i] + " ");
//     if ((i+1)%2 > 0)
//     {
//         nech = nech + rndArr[i];
//     }
// }
// Console.WriteLine($"\nСумму элементов, стоящих на нечётных позициях = {nech}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

using System.Linq;
System.Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(System.Console.ReadLine());
float[] rndArr = new float[a];
for (int i = 0; i < a; i++)
{
    rndArr[i] = new Random().Next(-99,99) + new Random().NextSingle();
    Console.Write(rndArr[i] + " ");
}
Console.WriteLine($"\nРазница между максимальным и минимальным элементами массива = {rndArr.Max() - rndArr.Min()}");