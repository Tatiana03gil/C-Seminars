/* Задача 1

Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

/*void ShowDiapazone (int quad)
{
    if (quad == 1) Console.WriteLine ("Диапазон х > 0 и y > 0");
    else if (quad == 2) Console.WriteLine ("Диапазон х < 0 и y > 0");
    else if (quad == 3) Console.WriteLine ("Диапазон х < 0 и y < 0");
    else if (quad == 4) Console.WriteLine ("Диапазон х > 0 и y < 0");
    else Console.WriteLine ("неправильный ввод");
    }

Console.WriteLine ("Введите номер четверти:");
int num = Convert.ToInt32 (Console.ReadLine ());
ShowDiapazone (num);
*/

/* Задача 2

Напишите программу, которая принимает на вход координаты 
точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
 плоскости, в которой находится эта точка.
*/

/*int NumQuad (int x, int y)
{
    int quad = -1;
    if (x > 0 && y > 0) quad =  1;
    else if (x < 0 && y > 0) quad = 2;
    else if (x < 0 && y < 0) quad = 3;
    else if (x > 0 && y < 0) quad = 4;
    else Console.WriteLine ("Wrong input");
    return quad;
    }

Console.WriteLine ("Введите координату X:");
int x1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координату Y:");
int y1 = Convert.ToInt32 (Console.ReadLine ());
int result = NumQuad (x1, y1);
Console.WriteLine ("Четверть: "+ result);
*/

/*Задача 3

Напишите программу, которая принимает на вход координаты двух
 точек и находит расстояние между ними в 2D пространстве.*/

 /*double Rasst (int x1, int y1, int x2, int y2){
    int k1 = x1 - x2;
    int k2 = y1 - y2;
    double gipotenuza = Math.Sqrt (k1*k1 + k2*k2);
    return gipotenuza;
 }

Console.WriteLine ("Введите координаты первой точки x1");
int x1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("y1");
int y1 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("Введите координаты второй точки x2");
int x2 = Convert.ToInt32 (Console.ReadLine ());
Console.WriteLine ("y2");
int y2 = Convert.ToInt32 (Console.ReadLine ());

double result = Rasst (x1, y1, x2, y2);
Console.WriteLine ("Расстояние равно " + result);
*/

 /* Задача 4
Напишите программу, которая принимает на вход число (N)
 и выдаёт таблицу квадратов чисел от 1 до N.*/

 void Kvadr (int Num){
    int count = 1;
        while (count <= Num){
            int kv = count * count;
            Console.WriteLine (count + " - " + kv);
            count++;
    }
 }

 Console.WriteLine ("Введите число: ");
 int N = Convert.ToInt32 (Console.ReadLine());
 Kvadr (N);