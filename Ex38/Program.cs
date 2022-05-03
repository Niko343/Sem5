// Задача 38: Задайте массив вещественных чисел. Найдите
//разницу между максимальным и минимальным
//элементов массива.

void FillArray(double[]mass, int a, int b)
{
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i] = (double) new Random().Next(a, b);
    }
}
void PrintArray(double[]mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}
double[] array = new double[10];
FillArray(array, -100, 100);
PrintArray(array);

int i = 0;
double min = array[i];
double max = array[i];

while (i < array.Length)
{
    if(array[i] > max)
    {
        max = array[i];
        i+=1;
    }

    else if (array[i] < min)
    {
        min = array[i];
        i+=1;
    }
    else
    {
        i += 1;
    }
}
double razn = max - min;
Console.WriteLine($"Разница между максимаьным и минимаьным эементами массива равна: {razn}");
