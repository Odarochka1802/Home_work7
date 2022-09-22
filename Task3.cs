/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

//Создаем массив с параметрами пользователя
int n = 0;
int m = 0;

Console.Write("Введите колличество строк: ");
bool parseIsOkN = int.TryParse(Console.ReadLine(), out int numberN);
if (!parseIsOkN)
{
    Console.WriteLine("Введено не коректное значение!");
    return;
}
else
    n = numberN;

Console.Write("Введите колличество столбцов: ");
bool parseIsOkM = int.TryParse(Console.ReadLine(), out int numberM);
if (!parseIsOkM)
{
    Console.WriteLine("Введено не коректное значение!");
    return;
}
else
    m = numberM;


//Заполняем массив рандомно 
int[,] getFillArray(int n, int m)
{
    int[,] array = new int[n, m];
    Random random = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array[i, j] = random.Next(0, 20); //Задаем диапазон 
        }
    }
    return array;
}

//Выводим наш массив для просмотра
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] array = getFillArray(n, m);
printArray(array);

//Развернули массив 
int[,] Rotate(int[,] array)
{
    int n = array.GetLength(0);
    int m = array.GetLength(1);
    int[,] result = new int[m, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            result[j, n - i - 1] = array[i, j];
    return result;
}
int[,] arrayNew = Rotate(array); //Новый массив

//Выводим среднее арифметическое столбца 
void printAverage(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {i}: {sum / array.GetLength(1)}");
    }

}
printAverage(arrayNew);