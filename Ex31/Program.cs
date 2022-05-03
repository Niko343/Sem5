// Задача 31: Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9]. Найдите сумму
//отрицательных и положительных элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна
//-20.

void Print(int[]array)
{Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");}

int[]array = new int[12];
int PolSum = 0;
int OtrSum = 0;


for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-9,9);
}
Print(array);
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        PolSum += array[i];
    }
    else
    {
        OtrSum += array[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма всех положительных чисел массива равна: {PolSum}");
Console.WriteLine($"Сумма всех отрицательных чисел массива равна: {OtrSum}");

