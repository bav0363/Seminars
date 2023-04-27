

// Задача 34: Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// int Input(string message) // Метод принимает на вход данные от пользователя и записывает их в переменную в виде числа
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] GenerateArray(int length) // Метод генерирует массив по заданным параметрам
// {
//     int[] array = new int[length];
//     for (int index = 0; index < length; index++)
//         array[index] = new Random().Next(100, 1000);
//     return array;
// }

// int QuantityOfEven(int[] array) // Метод вычисляет кол-во четных элементов в массиве
// {
//     int result = 0;
//     for (int index = 0; index < array.Length; index++) 
//         if (array[index] % 2 == 0) result += 1;
//     return result;
// }

// void ShowArray(int[] array) // Метод выводит полученный массив на печать
// {
//     for (int index = 0; index < array.Length; index++)
//         Console.Write(array[index] + " ");
//     Console.WriteLine();
// }

// int length = Input("Введите длину массива: ");
// int[] array = GenerateArray(length);
// ShowArray(array);
// Console.WriteLine($"Количество четных чисел в массиве: {QuantityOfEven(array)}");



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// int Input(string message) // Метод принимает на вход данные от пользователя и записывает их в переменную в виде числа
// {
//     Console.Write(message);
//     int result = Convert.ToInt32(Console.ReadLine());
//     return result;
// }

// int[] GenerateArray(int length, int minValue, int maxValue) // Метод генерирует массив по заданным параметрам
// {
//     int[] array = new int[length];
//     for (int index = 0; index < length; index++)
//         array[index] = new Random().Next(minValue, maxValue + 1);
//     return array;
// }

// int SumOfOdd(int[] array) // Метод принимает на вход массив и находит сумму его нечетных элементов
// {
//     int result = 0;
//     for (int index = 1; index < array.Length; index += 2)
//         result += array[index];
//     return result;
// }

// void ShowArray(int[] array) // Метод выводит массив на печать
// {
//     for (int index = 0; index < array.Length; index++)
//         Console.Write(array[index] + " ");
//     Console.WriteLine();
// }


// int length = Input("Введите длину массива: ");
// int minValue = Input("Введите минимальное значение в массиве: ");
// int maxValue = Input("Введите максимальное значение в массиве: ");
// int[] array = GenerateArray(length, minValue, maxValue);
// ShowArray(array);
// Console.WriteLine($"Сумма элементов на нечетных позициях в массиве равна: {SumOfOdd(array)}");



// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.


double[] CreationArray() // Метод создает массив из введенных параметров пользователем и показывает его в консоле
{
    Console.WriteLine("Введите размер массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[length];
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Введите элемент массива с индексом [{index}]: ");
        array[index] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array) // Метод показывает полученный массив
{
    for (int index = 0; index < array.Length; index++)
        Console.Write(array[index] + " ");
    Console.WriteLine();
}

double Differ(double[] array) // Метод находит разницу между максимальным и минимальным элементом массива
{
    double diff = 0;
    double min = array[0];
    double max = array[0];
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max) max = array[index];
        else if( array[index]<min) min = array[index];
    }
    diff = max - min;
    return diff;
}


double[] array = CreationArray();
ShowArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна: {Differ(array)}");









