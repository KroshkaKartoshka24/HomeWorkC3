// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

System.Console.WriteLine("Введите размер массива ");
int a = Convert.ToInt32(System.Console.ReadLine());
int[] rndArr = new int[a];
int ch = 0;
for (int i = 0; i < a; i++)
{
    rndArr[i] = new Random().Next(100,999);
    Console.Write(rndArr[i] + " ");
    if (rndArr[i]%2 == 0)
    {
        ch++;
    }
}
Console.WriteLine($"\nКоличество четных чисел в массиве = {ch}");