
int Input(string message) // Запоминает введенное значение
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[,] Generte2d(int rows, int cols, int minValue, int maxValue) // Генерация двумерного массива 
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return array;
}

double[,] Generte2ddouble(int rows, int cols) // Генерация двумерного вещественного массива 
{
    double[,] array = new double[rows, cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = Math.Round(new Random().Next(-100, 100) * 0.1, 1); // 1-й способ задать вещественный массив
            //array[i, j] = Math.Round(new Random().NextDouble() * 10, 1); // 2-й способ задать вещественный массив, но без отриц знач
        }
    }
    return array;
}

void ShowArray2d(int[,] array) // Вывод двумерного массива на печать
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray2dDouble(double[,] array) // Вывод двумерного массива на печать
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void M(int[,] array) // Метод находит среднее арифметическое значение по столбцам массива
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double M = 0;
        double sum = 0;
        int count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        M = Math.Round(sum / count, 2);
        Console.WriteLine($"Среднее арифметическое {j + 1} столбца составлаяет [{M}]");
    }
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// double[,] array = Generte2ddouble(rows, cols);
// ShowArray2dDouble(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// int rows = 5, cols = 5, minValue = 1, maxValue = 100;
// int[,] array = Generte2d(rows, cols, minValue, maxValue);
// ShowArray2d(array);
// int numberOfrow = Input("Введите номер строки элемента в массиве: ");
// int numberOfcols = Input("Введите номер столбца элемента в массиве: ");
// if (numberOfrow <= rows && numberOfcols <= cols) 
// {
//     int result = array[numberOfrow-1,numberOfcols-1];
//     Console.WriteLine($"По адресу {numberOfrow} строка, {numberOfcols} столбец находится элемент со значением {result}");    
// }
// else Console.WriteLine("Введенный адрес элемента находится за рамками массива");

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// int minValue = Input("Введите минимальное значение в массиве: ");
// int maxValue = Input("Введите максимальное значение в массиве: ");
// int[,] array = Generte2d(rows, cols, minValue, maxValue);
// ShowArray2d(array);
// M(array);





