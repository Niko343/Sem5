// Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

void Print(int[]array)
{Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");}

void ElemReplace(int[]array)
{
    for (int i = 0; i < array.Length; i++)
    {
       array[i] = array [i] * (-1);
    }
}

int[]array = new int[12];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
}
Print(array);
ElemReplace(array);
Console.WriteLine();
Print(array);

