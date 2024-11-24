using Tyuiu.GridinAE.Sprint4.Task0.V25.Lib;

Console.Title = "Спринт #4 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                          *");
Console.WriteLine("* Задание #0                                                           *");
Console.WriteLine("* Вариант #25                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный      *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму       *");
Console.WriteLine("* четных элементов массива.  {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}            *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().GetSumEvenArrEl([1, 4, 2, 6, 4, 8, 6, 7, 8, 4]));
Console.ReadKey();