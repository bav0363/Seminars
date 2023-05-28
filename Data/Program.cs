int Input(string message) // Ввод значения
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Generte(int length, int minValue, int maxValue) // Генерация одномерного массива 
{
    int[] array = new int[length];
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
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

void ShowArray(int[] array) // Вывод одномерного массива на печать
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

bool Check(int arg1, int arg2, int arg3) // Проверка на треугольник
{
    if (arg2 + arg3 >= arg1)
        if (arg1 + arg3 >= arg2)
            if (arg1 + arg2 >= arg3) return true;
    return false;
}

int[] Row(int length) // Ряд Фэбаначи
{
    int[] array = new int[length];
    array[0] = 0;
    array[1] = 1;
    for (int index = 2; index < length; index++)
    {
        array[index] = array[index - 1] + array[index - 2];
    }
    return array;
}

int[] Copy(int[] array) // Копирование массива
{
    int[] arraycopy = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
        arraycopy[index] = array[index];
    return arraycopy;
}

double[] CreationArray() // Заполнение одномерного массива с клавиатуры
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

int CreationArray2() // Метод принимает от пользователя числа и считает сколько из них положительных
{
    Console.WriteLine("Сколько чисел вы хотите ввести?: ");
    int length = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[length];
    int count = 0;
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"Введите число [{index + 1}]: ");
        array[index] = Convert.ToInt32(Console.ReadLine());
        if (array[index] > 0) count += 1;
    }
    return count;
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

int[,] ModArray(int[,] array) // метод упорядочивает по убыванию элементы строк в двумерном массиве
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int max = array[i, j];
            for (int m = j + 1; m < array.GetLength(1); m++)
            {
                if (array[i, m] > max)
                {
                    max = array[i, m];
                    int per = array[i, m];
                    array[i, m] = array[i, j];
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
    if (array1.GetLength(1) != array2.GetLength(0))
    {
        Console.WriteLine("Ошибка! Невозможно перемножить матрицы, так как кол-во столбцов первой матрицы не равно кол-ву строк во второй");
    }
    int[,] array2drezult = new int[array1.GetLength(0), array2.GetLength(1)];
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
    return array2drezult;
}

int[,,] Generate3d(int rows, int cols, int sections, int minValue, int maxValue) // Метод генерирует трехмерный массив
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

void ReverseArray(int[,] array) // Метод заменяет строки на столбцы
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
}

void ReverseRow(int[,] array) // Метод меняет между собой первую и последнюю строки
{
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[i, j];
        array[i, j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = temp;
    }
}

void ReverseAnyRow(int[,] array, int valueRow1, int valueRow2) // Метод меняет между собой любые заданные строки
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[valueRow1 - 1, j];
        array[valueRow1 - 1, j] = array[valueRow2 - 1, j];
        array[valueRow2 - 1, j] = temp;
    }
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
                    // for (int index = 0; index < current.Length; index++)
                    //     Console.Write(current[index] + " ");
                    // Console.WriteLine();
                }
            }
        }
    }
    return array;
}

int[,] Generte2d2(int rows, int cols) // Генерация двумерного массива и заполнение его по спиральни
{
    int[,] array = new int[rows, cols];
    int count = 1;
    int colStart = 0;
    int colEnd = cols - 1;
    int rowStart = 0;
    int rowEnd = rows - 1;
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

void FoundMinValue(int[,] array) // Метод показывает значение наименьшего элемента в массие, показывает его адрес и кол-во повторений
// проверяет, сколько раз повторяется наименьший элемент в массиве
{
    int minValue = array[0, 0];
    int count = 0;
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == minValue) count++;
        }
    }
    Console.WriteLine($"Наименьший элемент массива равен {minValue}");
    Console.WriteLine($"Наименьший элемент массива находится в {indexMinRow} строке {indexMinCol} столбца");
    Console.WriteLine($"Наименьший элемент массива повторяется {count} раз(а)");

}

void ReplaceRowAndCol(int[,] array) // Метод находит наименьший элемент массива, заменяет на нули значения в строке и столбце, на пересечении
// которых находится данный элемент
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
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[indexMinRow, j] = 0;
            array[i, indexMinCol] = 0;
        }
    }
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

int rows = 5; //Input("Введите кол-во строк в массиве: ");
int cols = 5; //Input("Введите кол-во столбцов в массиве: ");
int minValue = 1; // Input("Введите минимальное значение в массиве: ");
int maxValue = 30; //Input("Введите максимальное значение в массиве: ");
int[,] array2d = Generte2d(rows, cols, minValue, maxValue);
ShowArray2d(array2d);
FoundMinValue(array2d);
ShowArray2d(array2d);
int[,] rezultArray = DeleteRowAndCol(array2d);
ShowArray2d(rezultArray);









