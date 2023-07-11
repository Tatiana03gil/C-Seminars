/*Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).*/

void ShowDiapazone (int quad)
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

