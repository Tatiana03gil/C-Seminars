/* Напишите программу, которая принимает на вход некоторое число,
и возвращает сумму чисел от одного до этого числа.*/

/*int Sum (int number)
{
    int count = 1, sum = 0;
    while (count <= number) 
    {
        sum = sum + count;
        count++;
    }
    return sum;
}

Console.WriteLine ("Введите число N:");
int num = Convert.ToInt32 (Console.ReadLine());
int sum = Sum (num);
Console.WriteLine ("Сумма от 1 до " + num + " равна " + sum);*/

/*Напишите программу, которая принимает на вход число и возвращает
количество цифр в этом числе*/

/*int Length (int number)
{
    int length = 1;
    while (number > 10)
    {
        number = number / 10;
        length++;
    }
    return length;
}

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine());
int length = Length (num);
Console.WriteLine ("Длина числа " + length + " символа(ов)");*/

/*Напишите программу, которая принимает на вход некоторое число,
и возвращает произведение чисел от одного до этого числа.*/

/*int Factorial (int number)
{
    int fact = 1, count = 1;
    while (count <= number)
    {
        fact = fact*count;
        count++;
    }
    return fact;
}

Console.WriteLine ("Введите число N");
int num = Convert.ToInt32 (Console.ReadLine());
int result = Factorial (num);
Console.WriteLine ("Произведение от 1 до " + num + " равно: " + result);*/

int [] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next (minValue, maxValue+1);
    return array;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write (array[i] + " ");
    Console.WriteLine();
}

Console.Write ("input length array: ");
int length = Convert.ToInt32(Console.ReadLine());
Console.Write ("input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write ("input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(length, min, max);
ShowArray (myArray);