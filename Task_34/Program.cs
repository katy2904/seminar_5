/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int count = 0;
int [] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] =new Random().Next(100, 1000);
    if (array[i] % 2 == 0) count++;
}

Console.WriteLine($"В массиве [ {String.Join(", ", array)} ] четных чисел - {count}");