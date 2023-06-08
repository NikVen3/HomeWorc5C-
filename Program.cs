
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
/*
int[] GetArray(int size, int minValue, int maxValue)

{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++) 
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int [] array = GetArray(10, 100, 999);

Console.WriteLine($"Наш массив[{String.Join(";",array )}]");


int size = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i]% 2 ==0)
    size += 1;
}


Console.WriteLine($"Количество чётных чисел в массиве: {size}");
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

/*
int size = 5;

double[] array = new double[size];

for (int i = 0; i < array.Length; i++)
{

    array[i] = Math.Round((new Random().NextDouble() * new Random().Next(10, 100)), 2);

}

Console.WriteLine($"Массив чисел: [{String.Join("; ", array)}]");

double max = Int32.MinValue;
double min = Int32.MaxValue;

for (int z = 0; z < array.Length; z++)
{

    if (array[z] > max)

    {
        max = array[z];
    }

    if (array[z] < min)
    {

        min = array[z];

    }
}

Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] GetArray(int size, int minValue, int maxValue)

{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] array = GetArray(10, 1, 20);

Console.WriteLine($"Наш массив[{String.Join(";", array)}]");


int sum = 0;

for (int z = 0; z < array.Length; z += 2)
    sum = sum + array[z];

Console.WriteLine($"всего {array.Length } чисел, сумма элементов на нечётных позициях = {sum } ");
