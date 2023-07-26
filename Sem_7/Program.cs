/*Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.*/

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");

        Console.WriteLine();
    }
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(rows, col, min, max);
Show2dArray(myArray);

/*Задайте двумерный массив размера m на n, каждый элемент
 в массиве находится по формуле: Aij = i+j.
Выведите полученный массив на экран.*/

/*int[,] CreateNewdArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = i+j;
    return array;
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateNewdArray (rows, col);
Show2dArray (myArray);*/

/*Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.*/

/*void Squares (int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i = i+2)
        for (int j = 0; j < array.GetLength(1); j=j+2)
            array[i,j] *= array[i,j];
}

Squares (myArray);
Show2dArray (myArray);*/

/*Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д.*/

/*int SumDiag (int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0) || i<array.GetLength(1); i++)
        sum += array[i,i];
    return sum;
}

int result = SumDiag(myArray);
Console.WriteLine (result);*/