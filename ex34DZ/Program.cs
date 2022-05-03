// Задача 34: Задайте массив заполненный случайными
//положительными трёхзначными числами. Напишите
//программу, которая покажет количество чётных чисел в
//массиве.

void FillArray(int[]mass, int a, int b)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = new Random().Next(a, b);
    }
}
void PrintArray(int[]mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}
int count = 0;
int[] array = new int [10];
FillArray(array, 99, 1000);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.Write($"Количество чётных чисе в массиве: {count}");

