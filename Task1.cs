/*Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
int a = 0;
int b = 0;

//Проверяем на корректность внесенных данных

Console.Write("Введите колличество строк: ");
bool parseIsOkA = int.TryParse(Console.ReadLine(), out int numberA);

if (!parseIsOkA)
{
    Console.WriteLine("Введено некорректное значение!");
    return;
}
else
    a = numberA;

Console.Write("Введите колличество столбцов: ");
bool parseIsOkB = int.TryParse(Console.ReadLine(), out int numberB);
if (!parseIsOkB)
{
    Console.WriteLine("Введено некорректное значение!");
    return;
}
else
    b = numberB;

//Создаем массив 
double[,] fillArrayDouble(int a, int b)
{
    double[,] array = new double[a, b];

    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            array[i, j] = random.NextDouble() * 10; // NextDouble() дает случайное вещественное число в диапазоне от 1 до 10
        }
    }
    return array;
}

//Печатаем массив
void printArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6:F2}", array[i, j]);
        }
        Console.WriteLine();
    }
}

printArray(fillArrayDouble(a, b));