/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double maximum = 0;
double [] array = new double[size];
for (int i = 0; i < size; i++)
{
    array[i] = Convert.ToDouble(new Random().Next(100));
    if (array[i] > maximum) maximum = array[i];    
}

double minimum = array[0];
for (int i = 0; i < size; i++)
{
    if (array[i] < minimum) minimum = array[i];
}

Console.WriteLine($"В массиве [ {String.Join(", ", array)} ] \n"
    + $"максимальный элемент равен {maximum}, минимальный элемент равен {minimum}, "
    + $"а их разница равна {maximum - minimum}");