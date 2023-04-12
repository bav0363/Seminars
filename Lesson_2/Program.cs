void FillArray(int[] collection)         // Метод заполнение массива с заданным размером случайным числами в интервале от 1 до 19
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 20);
        index++;
    }
}

void PrintArray(int[] collection)        // Метод вывод массива на печать
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write(collection[index] + " ");
        index++;
    }
}

int IndexOf(int[] collection, int find)  // Метод нахождение индекса элемента в массиве, соответствующего заданному условию      
{
    int count = collection.Length;
    int index = 0;
    int position = -1;      // -1 - будет выводится, если совпадение не найдено в массиве 

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;              // оставновить цикл как только будет найдено первое совпадение            
        }
        index++;
    }
    return position;
}


int[] array = new int[20];      // Определили, что нам нужно сгенерировать массив из 20 элементов
FillArray(array);               // Заполнили массив случайными числами в интервале от 1 до 20 (20 не входит)
PrintArray(array);              // Напечатали полученный массив
Console.WriteLine();            // Можно вставить пустую строчку, чтобы результат не сливался в консоле
int pos = IndexOf(array, 15);   // Записали результат работы метода в переменную 
Console.WriteLine(pos);         // Вывели на печать полученную переменную