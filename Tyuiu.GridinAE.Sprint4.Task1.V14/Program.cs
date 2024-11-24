using Tyuiu.GridinAE.Sprint4.Task1.V14.Lib;


Console.Title = "Спринт #4 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                        *");
Console.WriteLine("* Задание #1                                                           *");
Console.WriteLine("* Вариант #14                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов заполненный      *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8 подсчитать             *");
Console.WriteLine("* сумму нечетных элементов массива.                                    *");
Console.WriteLine("* С клавиатуры: 1, 5, 3, 6, 5, 4, 8, 6, 8, 4, 2, 3, 1                  *");
Console.WriteLine("************************************************************************");

int[] array = new int[13];

string? input;

for(int i = 1; i <= 13; i++)
{
    Console.WriteLine($"Введите число №{i}: ");
    input = Console.ReadLine();
    i++;

    array[i - 1] = Convert.ToInt32(input);
}W

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(array));

Console.ReadKey();