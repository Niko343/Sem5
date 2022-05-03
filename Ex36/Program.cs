// Задача 36: Задайте одномерный массив, заполненный
//случайными числами. Найдите сумму элементов, стоящих
//на нечётных позициях.
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
int[]array = new int [10];
FillArray(array, -10, 10);
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 0)
    {
        count = count;
    }
    else
    {
        count = count + array[i];
    }
}
Console.Write($"Сумма элементов на нечётных позициях массива равна: {count}");
