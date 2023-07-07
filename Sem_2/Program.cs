/*Напишите программу, которая выводит случайное
трёхзначное число и удаляет вторую цифру этого числа.
*/

/*int CutNumber (int num)
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
*/

/*Напишите программу, которая принимает на вход число и проверяет,
кратно ли оно одновременно a и b.*/

/*bool IsDividable (int number, int a, int b){
if (number % a == 0 && number % b == 0) return true;
else return false;
} 

Console.WriteLine ("Введите число: ");
int num = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите первый делитель: ");
int div1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второй делитель: ");
int div2 = Convert.ToInt32 (Console.ReadLine ());
bool result = IsDividable (num, div1, div2);
Console.WriteLine (result);
*/

/*Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа.*/

/*int MaxNum (int RandNum){

    int decade = RandNum / 10;
    int units = RandNum % 10;
    int max = decade;
    if (decade < units) max = units;
    return max;
        }

int Rand = new Random ().Next (10, 100);
Console.WriteLine ("Наше случайное число: " + Rand);
int result = MaxNum (Rand);
Console.WriteLine ("Больше цифра " + result);
*/

/*Напишите программу, которая принимает на вход два числа
 и проверяет, является ли одно число квадратом другого.*/

/*bool Kvadr (int num1, int num2){

 if (num1 == num2*num2 || num2 == num1*num1) return true;
 else return false;}

Console.WriteLine ("Введите первое число: ");
int number1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите второе число: ");
int number2 = Convert.ToInt32 (Console.ReadLine ());

bool result = Kvadr (number1, number2);
Console.WriteLine ("Одно число квадрат другого? " + result);
*/