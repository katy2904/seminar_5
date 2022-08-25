/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов,
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int count = 0;
int [] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] =new Random().Next(100);
    if (i % 2 != 0) count += array[i];
}

Console.WriteLine($"В массиве [ {String.Join(", ", array)} ] "
    + $"cумма элементов нечетных позиций равна {count}");