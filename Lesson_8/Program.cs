
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

void ShowArray(int[] array) // Вывод массива на печать
{
    for (int index = 0; index < array.Length; index++)
        Console.Write(array[index] + " ");
    Console.WriteLine();
}

void ShowArray2d(int[,] array) // Вывод двумерного массива на печать
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,5}", array[i, j] + " "));
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ModArray(int[,] array) // метод упорядочивает по убыванию элементы строк в двумерном массиве
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = array[i, j];
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] > max)
                {
                    max = array[i, k];
                    int per = array[i, k];
                    array[i, k] = array[i, j];
                    array[i, j] = per;
                }
            }
        }
    }
    return array;
}

int[] SumOfRows(int[,] array) // метод возвращает одномерный массив с суммой строк двумерного массива
{
    int[] arraysumrows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfrow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfrow += array[i, j];
        }
        arraysumrows[i] = sumOfrow;
    }
    return arraysumrows;
}

int MinValueOfArray(int[] array) // метод возвращает индекс минимального элемента одномерного массива
{
    int index = 1;
    int minValue = array[index - 1];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minValue)
        {
            minValue = array[i];
            index = i + 1;
        }
    }
    return index;
}

int[,] Array2dMultiplication(int[,] array1, int[,] array2) // метод перемножает две двумерные матрицы
{
    int[,] array2drezult = new int[array1.GetLength(0), array2.GetLength(1)];
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Ошибка! Невозможно перемножить матрицы, так как кол-во столбцов первой матрицы не равно кол-ву строк во второй");
    }
    else
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array2drezult[i, j] = 0;
                for (int k = 0; k < array1.GetLength(0); k++)
                {
                    array2drezult[i, j] += array1[i, k] * array2[k, j];
                }
            }
        }
    }
    return array2drezult;
}

int[,,] Generate3d(int rows, int cols, int sections, int minValue, int maxValue) // заполнение трехмерного массива случайными числами
{
    int[,,] array = new int[rows, cols, sections];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < sections; k++)
            {
                array[i, j, k] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return array;
}

int[,,] Generate3d1(int rows, int cols, int sections, int minValue, int maxValue) // заполнение трехмерного массива случайными уник.числами
{
    int[,,] array = new int[rows, cols, sections];
    int[] current = new int[rows * cols * sections];
    bool searchRepeat;
    int count = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            for (int k = 0; k < sections;)
            {
                searchRepeat = false;
                int newValue = new Random().Next(minValue, maxValue + 1);
                for (int m = 0; m < count; m++)
                {
                    if (current[m] == newValue)
                    {
                        searchRepeat = true;
                        break;
                    }
                }
                if (!searchRepeat)
                {
                    array[i, j, k] = newValue;
                    current[count] = newValue;
                    k++;
                    count++;                   
                }
            }
        }
    }
    return array;
}

void ShowArray3d(int[,,] array) // Вывод трехмерного массива на печать
{
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                Console.Write(String.Format("{0,3}", array[j, k, i]) + (j, k, i));
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Generte2d2(int rows, int cols) // Генерация двумерного массива и заполнение его по спиральни
{
    int[,] array = new int[rows, cols];
    int count = 1;
    int colStart = 0;
    int colEnd = cols-1;
    int rowStart = 0;
    int rowEnd = rows-1;
    while (colStart <= colEnd && rowStart <= rowEnd)
    {
        for (int i = rowStart; i <= colEnd; i++)
        {
            array[rowStart, i] = count;
            count++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = count;
            count++;
        }
        colEnd--;

        for (int i = colEnd; i >= colStart; i--)
        {
            array[rowEnd, i] = count;
            count++;
        }
        rowEnd--;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            array[i, colStart] = count;
            count++;
        }
        colStart++;
    }


    return array;
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// int minValue = Input("Введите минимальное значение в массиве: ");
// int maxValue = Input("Введите максимальное значение в массиве: ");
// int[,] array2d = Generte2d(rows, cols, minValue, maxValue);
// ShowArray2d(array2d);
// int[,] array2dmod = ModArray(array2d);
// ShowArray2d(array2dmod);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// int minValue = Input("Введите минимальное значение в массиве: ");
// int maxValue = Input("Введите максимальное значение в массиве: ");
// int[,] array2d = Generte2d(rows, cols, minValue, maxValue); // генерируем двумерный массив
// ShowArray2d(array2d);
// int[] arraySumRows = SumOfRows(array2d); // создаем одномерный массив с суммой строк двумерного массива
// ShowArray(arraySumRows);
// Console.WriteLine($"Наименьшая сумма элементов массива находится в строке {MinValueOfArray(arraySumRows)}"); // показываем наименьшее значение

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// int minValue = Input("Введите минимальное значение в массиве: ");
// int maxValue = Input("Введите максимальное значение в массиве: ");
// int[,] array2dA = Generte2d(rows, cols, minValue, maxValue); // генерируем первый двумерный массив
// ShowArray2d(array2dA);
// int[,] array2dB = Generte2d(rows, cols, minValue, maxValue); // генерируем второй двумерный массив
// ShowArray2d(array2dB);
// int[,] array2drezult = Array2dMultiplication(array2dA, array2dB); // перемножаем два двумерных массива
// ShowArray2d(array2drezult);

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// int sections = Input("Введите кол-во срезов в массиве: ");
// int minValue = Input("Введите минимальное значение в массиве: ");
// int maxValue = Input("Введите максимальное значение в массиве: ");
// int[,,] array3d = Generate3d1(rows, cols, sections, minValue, maxValue);
// ShowArray3d(array3d);

//Задача 62. Напишите программу, которая заполнит массив спирально

// int rows = Input("Введите кол-во строк в массиве: ");
// int cols = Input("Введите кол-во столбцов в массиве: ");
// // int minValue = Input("Введите минимальное значение в массиве: ");
// // int maxValue = Input("Введите максимальное значение в массиве: ");
// int[,] array2dA = Generte2d2(rows, cols); // генерируем первый двумерный массив и заполняем его по спирали
// ShowArray2d(array2dA);
