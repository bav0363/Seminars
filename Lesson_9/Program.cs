int Input(string message) // Ввод значения
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] FromNto1(int n)
{
    int[] array = new int[n];

    for (int index = 0; index < array.Length; index++)
    {
        array[index] = n - index;
        Console.Write(array[index] + " ");
    }
    Console.WriteLine();
    return array;
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



int n = Input("Введите кол-во строк в массиве: ");
int[] array = FromNto1(n);


