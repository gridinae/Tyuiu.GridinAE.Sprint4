using Tyuiu.GridinAE.Sprint4.Task6.V30.Lib;

Console.Title = "Спринт #4 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Класс Array                                                    *");
Console.WriteLine("* Задание #6                                                           *");
Console.WriteLine("* Вариант #30                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан строковый массив данных                                          *");
Console.WriteLine("* [\"Береза\", \"Дуб\", \"Клён\", \"Сосна\", \"Пихта\", \"Осина\"],                *");
Console.WriteLine("* используя класс Array, выведите элементы массива, длина              *");
Console.WriteLine("* которых больше 5 символов.                                           *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

new DataService().Calculate(["Береза", "Дуб", "Клён", "Сосна", "Пихта", "Осина"]).ToList().ForEach(Console.WriteLine);
Console.ReadKey();
