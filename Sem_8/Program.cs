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
    Console.WriteLine();
}

Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of columns: ");
int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

/*Задайте двумерный массив. 
Напишите программу, которая поменяет 
местами первую и последнюю строку массива.*/

/*void ChangeRows (int[,] array, int row1, int row2)
{
    if (row1 >=0 && row1 < array.GetLength(0) &&
        row2 >=0 && row1 < array.GetLength(0) &&
        row1 != row2)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            int temp = array[row1,j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

int[,] myArray = CreateRandom2dArray(rows, col, min, max);
Show2dArray(myArray);

Console.WriteLine("Input number of first row to change: ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number of second row to change: ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows (myArray, r1, r2);
Show2dArray(myArray);*/

/*Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы.*/

/*void ChangeArray (int[,]array)
{
    if (array.GetLength(0) == array.GetLength(1))
    for (int i = 1; i < array.GetLength(0); i++)
        for (int j = 0; j < i; j++)
        {
            int temp = array[i,j];
            array [i,j] = array[j,i];
            array [j,i] = temp;
        }
}

int[,] newArray = CreateRandom2dArray (rows, col, min, max);
Show2dArray (newArray);
ChangeArray (newArray);
Show2dArray (newArray);*/


/*Из двумерного массива целых чисел 
удалить строку и столбец, на пересечении
которых расположен наименьший элемент.*/

int[] IndexOfMin(int[,] array)
{
    int[] coordinates = new int[2];
    int min = array[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                coordinates[0] = i;
                coordinates[1] = j;
            }
        }
    return coordinates;
}

/*void ChangeToZero(int[,] array, int[] coordinates)
{
    for (int i = coordinates[0], j = 0; j < array.GetLength(1); j++)
        array[i, j] = 0;
    for (int j = coordinates[1], i = 0; i < array.GetLength(0); i++)
        array[i, j] = 0;
}*/

/*int[,] DeletedRowsColumns (int[,]array, int[] coordinates)
{
    int[,] newArray = new int [array.GetLength(0)-1, array.GetLength(1)-1];
    for (int i=0, m=0; i < array.GetLength(0); i++, m++)
    {
        if (i != coordinates[0])
            for (int j=0, l=0; j<array.GetLength(1); j++, l++)
            {
                if (j != coordinates[1]) newArray[m,l] = array[i,j];
                else l--;
            }
        else m--;
    }
return newArray;
}

int [,] firstArray = CreateRandom2dArray (rows, col, min, max);
Show2dArray (firstArray);
int [] coord = IndexOfMin (firstArray);
int[,] result = DeletedRowsColumns (firstArray, coord);
Show2dArray (result);*/