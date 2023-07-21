/*int[] RandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i =0; i<size; i++)
        array[i]=new Random().Next(minValue, maxValue+1);
    return array; 
}*/

/*void ShowArray (int[] array)
{
    for (int i=0; i < array.Length; i++ )
        Console.Write (array[i] + "  ");
    Console.WriteLine ();
}*/

/*Console.WriteLine ("size");
int size = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("min");
int min = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("max");
int max = Convert.ToInt32 (Console.ReadLine());*/

/*Напишите программу, которая перевернёт одномерный
массив (последний элемент будет на первом месте,
а первый - на последнем и т.д.)*/

/*void ReverseArray (int[] array)
{
    for (int i = 0; i < array.Length/2; i++)
    {
        int temp = array [i];
        array[i] = array [array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

int[] myArray = RandomArray(size, min, max);
ShowArray(myArray);
ReverseArray(myArray);
Console.WriteLine();
ShowArray(myArray);*/

/*Напишите программу, которая принимает на вход 
три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины.*/

/*bool Triangle (int[]array)
{
    if (array[0]<array[1]+array[2] && array[1]<array[0]+array[2] && array[2]<array[1]+array[0])return true;
    else return false;

}

int[] myArray = {5, 8, 9};
Console.WriteLine (Triangle (myArray));*/

/*Не используя рекурсию, выведите первые N 
чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/

/*int[] Fibonacci (int n)
{
    int[] array = new int [n];
    array [0] = 0;
    array [1] = 1;
    for (int i = 2; i < n; i++) 
        array[i] = array [i-2] + array [i-1];
    return array;
}

Console.WriteLine ("Input N");
int n = Convert.ToInt32 (Console.ReadLine());
int[]myArray = Fibonacci (n);
ShowArray (myArray);*/

/*Напишите программу, которая будет создавать копию 
заданного массива с помощью поэлементного копирования.*/

/*int[] CopyArray (int[] array)
{
    int[] newArray = new int [array.Length];
    for (int i = 0; i<array.Length; i++)
        newArray[i] = array[i];
    return newArray;
}

int [] myArray = RandomArray (5, 1, 10);
ShowArray (myArray);
int [] copy = CopyArray (myArray);
ShowArray (copy);*/
