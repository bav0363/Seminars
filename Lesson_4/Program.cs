// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// double Exponentiation(double number, double degree) // Метод принимает на вход рациональное число А и натуральное число В,
// // а затем возводит число А в степень В
// {
//     double result = 1;
//     if (degree >= 1 && degree % 1 == 0)
//     {
//         for (int count = 1; count <= degree; count++)
//         {
//             result = result * number;
//         }
//     }
//     else result = -1;
//     return result;
// }

// Console.WriteLine("Введите число: ");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите степень: ");
// double degree = Convert.ToDouble(Console.ReadLine());
// double exponentiation = Math.Round(Exponentiation(number, degree), 2);
// if (exponentiation == -1) Console.WriteLine($"Степень должна быть целым натуральным числом. Повторите ввод");
// else Console.WriteLine($"Число {number} в степени {degree} будет равно {exponentiation}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int Sum(int number)
// {
//     int result = 0;
//     for (int count = 1; number != 0; count++)
//     {
//         result = result + number % 10;
//         number = number / 10;
//     }
//     return Math.Abs(result);
// }

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Cумма цифр в числе {number} будет равна {Sum(number)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// void FillArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         collection[index] = new Random().Next(1, 100);
//         index++;
//     }

// }

// void PrintArray(int[] collection)
// {
//     int lenght = collection.Length;
//     int index = 0;
//     while (index < lenght)
//     {
//         Console.Write($"{collection[index]} ");
//         index++;
//     }

// }

// Console.WriteLine("Введите размер массива для генерации: ");
// int collection = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[collection];
// FillArray(array);
// PrintArray(array);



