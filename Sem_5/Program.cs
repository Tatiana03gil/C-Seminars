/*Задайте массив из 12 элементов, заполненный случайными
числами из промежутка [-9, 9]. 
Найдите сумму отрицательных элементов массива.*/

/*int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i =0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array;    
}

void ShowArray (int[] array)
{
    for (int i=0; i < array.Length; i++ )
        Console.Write (array[i] + "  ");
}

int SumNegative (int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]<0) sum += array[i];
    }
    return sum;
}

Console.WriteLine ("size");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("min");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("max");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = RandomArray (size, min, max);
ShowArray (myArray);
Console.WriteLine ();

int sum = SumNegative (myArray);

Console.WriteLine ("сумма отриательных чисел  " + sum);*/

/*Напишите программу замена элементов массива: 
положительные элементы замените на соответствующие отрицательные, и наоборот.*/

/*int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i =0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array;    
}

void ShowArray (int[] array)
{
    for (int i=0; i < array.Length; i++ )
        Console.Write (array[i] + "  ");
}

int[] ChangeSignArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = 0 - array[i];
    return array;
}

Console.WriteLine ("size");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("min");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("max");
int max = Convert.ToInt32 (Console.ReadLine());

int[] myArray = RandomArray (size, min, max);
ShowArray (myArray);
Console.WriteLine ();

int[] changedArray = ChangeSignArray (myArray);
ShowArray (changedArray);
Console.WriteLine ();*/

/*Задайте массив. Напишите программу, которая определяет,
 присутствует ли заданное число в массиве.*/

int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i =0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array;    
}

void ShowArray (int[] array)
{
    for (int i=0; i < array.Length; i++ )
        Console.Write (array[i] + "  ");
}

bool IsThere (int[] array, int number)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {
            return true;
            break;
        }
    }
    return false;
}

Console.WriteLine ("size");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("min");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("max");
int max = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("number");
int num = Convert.ToInt32 (Console.ReadLine());

int[] myArray = RandomArray (size, min, max);
ShowArray (myArray);
Console.WriteLine ();

bool result = IsThere (myArray, num);
Console.WriteLine (result);

/*Задайте одномерный массив из m случайных чисел. 
Найдите количество элементов массива, 
значения которых лежат в отрезке [a,b].*/

/*int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i =0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array;    
}

void ShowArray (int[] array)
{
    for (int i=0; i < array.Length; i++ )
        Console.Write (array[i] + "  ");
}

int CountOfElements (int[] array, int diapMinValue, int diapMaxValue)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i]>= diapMinValue && array[i]<=diapMaxValue) count++;
    return count;
}

Console.WriteLine ("size");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("min");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("max");
int max = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("minD");
int minD = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("maxD");
int maxD = Convert.ToInt32 (Console.ReadLine());

int[] myArray = RandomArray (size, min, max);
ShowArray (myArray);
Console.WriteLine ();
int result = CountOfElements (myArray, minD, maxD);
Console.WriteLine ("Число элементоа " + result);*/