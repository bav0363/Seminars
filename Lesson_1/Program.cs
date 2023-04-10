// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Console.Write("Введите первое число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// if(number1 >= number2)
// {
//     Console.WriteLine("Наибольшее число: " + number1);
//     Console.WriteLine("Наименьшее число: " + number2);
// }
// else
// {
//     Console.WriteLine("Наибольшее число: " + number2);
//     Console.WriteLine("Наименьшее число: " + number1);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max_number = number1;

if(number2 > max_number)
{
    max_number = number2;
}

if(number3 > max_number)
{
    max_number = number3;
}
Console.WriteLine("Максимальное значение из введенных чисел: " + max_number);

