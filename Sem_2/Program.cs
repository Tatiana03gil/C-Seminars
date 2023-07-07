/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого числа.
*/

int CutNumber (int num)
{
    int hundreds = num / 100;
    int units = num % 10;
    int result = hundreds*10 + units;
    return result;
}

int number = new Random().Next(100,1000);
Console.WriteLine ("Наше случайное число: " + number);
int newNumber = CutNumber (number);
Console.WriteLine ("Новая версия числа: " + newNumber);
