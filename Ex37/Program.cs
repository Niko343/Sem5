// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

void FillArray(int[]array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
    }
}
void Print(int[]mass)
{
    for (int i = 0; i < mass.Length; i++)
    {
        Console.Write(mass[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите размер массива: ");
int d = int.Parse(Console.ReadLine());
int[]array = new int[d];
FillArray(array, 0, 10);
Print(array);


int [] result = new int[(array.Length + 1) / 2]; 

for (int i = 0; i < array.Length / 2; i++)
{
    result[i] = array[i] * array[(array.Length - 1) - i];
}
if (array.Length % 2 == 1)
{
    result[result.Length - 1] = array[result.Length - 1];
}
Print(result);

