
double Input(string message) // Запоминает введенное значение
{
    Console.Write(message);
    double result = Convert.ToDouble(Console.ReadLine());
    return result;
}

int[] Generte(int length, int minValue, int maxValue) // Генерация массива 
{
    int[] array = new int[length];
    for (int index = 0; index < length; index++)
    {
        array[index] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void ShowArray(int[] array) // Вывод массива на печать
{
    for (int index = 0; index < array.Length; index++)
        Console.Write(array[index] + " ");
    Console.WriteLine();
}

bool Check(int arg1, int arg2, int arg3) // Проверка на сторон треугольника
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

// Задача41. Пользователь вносит с клавиатуры М чисел. Определить, сколько он ввел положительных чисел.

// int count = CreationArray2();
// Console.WriteLine($"Количество положительных чисел: {count}");


// // Задача43. Найти точку пересечени двух прямых, заданных уравнениями y=k1*x+b1 и y=k2*x+b2

// Console.WriteLine($"Нахождение точек пересечения прямых, заданных уравнениями y=k1*x+b1 и y=k2*x+b2");
// double k1 = Input("Введите значение k1: ");
// double b1 = Input("Введите значение b1: ");
// double k2 = Input("Введите значение k2: ");
// double b2 = Input("Введите значение b2: ");
// double x = (-b2 + b1) / (k2 - k1);
// double y = k1 * x + b1;
// Console.WriteLine($"Координата точки пересечения двух прямых: ({Math.Round(x,2)}, {Math.Round(y,2)})");


