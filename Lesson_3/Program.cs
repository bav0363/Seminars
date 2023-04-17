
// Задача 19/ Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// bool PolydromeCheck(int number) // Метод принимает на вход натуральное число и делает проверку на его полиндромность
// {
//     string convert = Convert.ToString(number);
//     int lenght = convert.Length;    
//     int count = 1;
//     string coup = "";
//     while (count <= lenght)
//     {
//         coup = coup + number % 10;
//         number = number / 10;
//         count++;
//     }

//     if (convert == coup) return true;
//     else return false;
// }

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number >= 1)
// {
//     if (PolydromeCheck(number)) 
//         Console.WriteLine($"Введенное число {number} является полидромом!");
//     else 
//         Console.WriteLine($"Введенное число {number} НЕ является полидромом!");
// }
// else
//     Console.WriteLine("Ошибка! Введите натуральное число");


// // Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(double x1, double y1, double z1, double x2, double y2, double z2) // Метод на вход принимает координаты двух точек в 3D 
// // пространстве и выводит расстояние между ними
// {
//     double distBetween = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));
//     return distBetween;
// }

// Console.WriteLine("Введите коорлинаты ПЕРВОЙ точки:");
// Console.Write("X = ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y = ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Z = ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите коорлинаты ВТОРОЙ точки:");
// Console.Write("X = ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Y = ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Z = ");
// double z2 = Convert.ToDouble(Console.ReadLine());
// double distBetween = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2);
// Console.WriteLine($"Расстояние между точками составляет {distBetween}");


// // Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void CubeTable(int number) // Метод принимает на вход натуральное число и выводит в консоль таблицу кубов 
// //  от 1 до этого числа
// {
//     int cubeOfnumber = 0;
//     int count = 1;
//     Console.WriteLine($"Таблица кубов чисел от 1 до {number}:");
//     while (count < number + 1)
//     {
//         cubeOfnumber = count * count * count;
//         Console.WriteLine(cubeOfnumber);
//         count++;
//     }
// }

// Console.Write("Введите натуральное число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1)
// {
//     Console.WriteLine("Недопустимое значение. Повторите попытку");
// }
// else
// {
//     CubeTable(number);
// }