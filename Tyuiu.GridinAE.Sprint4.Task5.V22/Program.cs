using Tyuiu.GridinAE.Sprint4.Task5.V22.Lib;

Console.Title = "Спринт #4 | Выполнил: Гридин А. Е. | ИИПБ-24-2";
Console.WriteLine("************************************************************************");
Console.WriteLine("* Спринт #4                                                            *");
Console.WriteLine("* Тема: Двумерные массивы. (генератор случайных чисел)                 *");
Console.WriteLine("* Задание #5                                                           *");
Console.WriteLine("* Вариант #22                                                          *");
Console.WriteLine("* Выполнил: Гридин Артём Евгеньевич | ИИПБ-24-2                        *");
Console.WriteLine("************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                             *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     *");
Console.WriteLine("* случайными значениями в диапазоне от -8 до 9.                        *");
Console.WriteLine("* Найти количество отрицательных элементов.                            *");
Console.WriteLine("************************************************************************");

Console.WriteLine("Массив: ");
Random rnd = new();
int[,] matrix = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        int randint = rnd.Next(-8, 10);
        if (randint < 0)
            Console.Write(' ');
        else
            Console.Write("  ");
        Console.Write(randint);
        matrix[i, j] = randint;
    }
    Console.Write('\n');
}

Console.WriteLine("************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
Console.WriteLine("************************************************************************");

Console.WriteLine(new DataService().Calculate(matrix));
Console.ReadKey();