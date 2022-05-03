// Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

void FillArray(int[]array, int a, int b)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(a, b);
    }
}

void Print(int[]array)
{Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.Write("]");}

int[] array = new int[10];
FillArray(array, -100, 100);
Print(array);
Console.WriteLine();

Console.Write("Введите искомое число: ");
int a = int.Parse(Console.ReadLine());
int exist = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == a)
    {
    exist += 1;
    }
}
if(exist > 0)
{
    Console.WriteLine("Число содержится в массиве");
} else Console.WriteLine("Число не содержится в массиве");

     
