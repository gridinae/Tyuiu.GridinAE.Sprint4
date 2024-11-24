using Tyuiu.GridinAE.Sprint4.Task2.V6.Lib;


Console.Title = "Спринт #4 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Одномерные массивы. (генератор случайных чисел)                *");
Console.WriteLine("* Задание #2                                                           *");
Console.WriteLine("* Вариант #6                                                           *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов заполненный      *");
Console.WriteLine("* случайными в диапазоне от 2 до 8 подсчитать произведение нечетных    *");
Console.WriteLine("* элементов массива.                                                   *");
Console.WriteLine("************************************************************************");
var rnd = new Random();
var array = new int[15];

Console.Write($"Массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(2, 9);
    Console.Write(array[i] + " ");
}

Console.Write('\n');
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(array));
Console.ReadKey();