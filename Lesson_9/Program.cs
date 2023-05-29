int Input(string message) // Ввод значения
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void FromNto1(int n) // метод выводит значения от n до 1
{
    Console.Write(n + " ");
    if (n > 1) FromNto1(n - 1);
}

int[,] DeleteRowAndCol(int[,] array) // Метод находит наименьший элемент массива и удаляет из масива строку и столбец с данным элементом
{
    int minValue = array[0, 0];
    int indexMinRow = 0;
    int indexMinCol = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minValue)
            {
                minValue = array[i, j];
                indexMinRow = i;
                indexMinCol = j;
            }
        }
    }
    int[,] rezultArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < rezultArray.GetLength(0); i++)
    {
        for (int j = 0; j < rezultArray.GetLength(1); j++)
        {
            if (i < indexMinRow && j >= indexMinCol) rezultArray[i, j] = array[i, j + 1];
            else if (i >= indexMinRow && j < indexMinCol) rezultArray[i, j] = array[i + 1, j];
            else if (i >= indexMinRow && j >= indexMinCol) rezultArray[i, j] = array[i + 1, j + 1];
            else rezultArray[i, j] = array[i, j];
        }
    }
    return rezultArray;
}

int SumMtoN(int m, int n) // Метод находит сумму в промежутке заданных чисел
{
    if (m < n) return SumMtoN(m + 1, n) + m;
    else if (m > n) return SumMtoN(m, n + 1) + n;
    else return m;
}

int Ackerman(int n, int m) // Метод Аккермана
{
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ackerman(n - 1, 1);
    if (n > 0 && m > 0) return Ackerman(n - 1, Ackerman(n, m - 1));
    return Ackerman(n, m);
}

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// int n = Input("Введите число: ");
// FromNto1(n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int m = Input("Введите число m: ");
// int n = Input("Введите число n: ");
// Console.WriteLine($"Сумма элементов равна {SumMtoN(m, n)}");

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int m = Input("Введите число m: ");
// int n = Input("Введите число n: ");
// Console.WriteLine($"Функция Аккермана равна {Ackerman(m, n)}");



