using Tyuiu.GridinAE.Sprint4.Task7.V29.Lib;

Console.Title = "Спринт #4 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту              *");
Console.WriteLine("* Задание #7                                                           *");
Console.WriteLine("* Вариант #29                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дана строка из одноразрядных цифр \"983157642891\".                    *");
Console.WriteLine("* Преобразуйте ее в матрицу 4 на 3 и подсчитайте сумму четных чисел.   *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(4, 3, "983157642891"));

Console.ReadKey();