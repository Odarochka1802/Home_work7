/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/


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

Console.Write("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

//Метод проверки и вывода числа на заданной позиции
void checkPosition(int[,] array, int a, int b)
{
    if (a > array.GetLength(0) || b > array.GetLength(1))
        Console.WriteLine("Позиция находится за пределами массива");
    else
    {
        Console.WriteLine($"Элемент на позиции [{a},{b}] - {array[a, b]}");
    }
}
checkPosition(array, a, b);

/*Я почему-то задание с первых трех прочтений не так поняла. Уже когда написала прояснило.
Но код жалко. Поэтому оставлю
Здесь я искала заданное значение в массиве, а не позицию.

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

//Выведим наш массив для промотра 

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

void checkArrayPosition(int[,] array, int value)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == value)
            {
                Console.WriteLine($"[{i},{j}]");
                return;

            }

        }
        
    }
    Console.WriteLine("такого элемента нет");
}
Console.Write("Введите Значение для поиска: ");
int value = int.Parse(Console.ReadLine());
checkArrayPosition(array,value);
*/
