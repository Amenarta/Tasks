/*
//Задача №19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool Palendrome(string text)
{
  int len = text.Length;

  for(int i = 0; i < len/2; i++)
  {
    if (text [i] != text[len-i-1])
    return false;
  }
  return true;
}

int phrase()
{  
   
  if (Palendrome(a))
    Console.Write("Это палиндром.");
  else
    Console.Write("Это не палиндромю");
  return 0;
}
Console.Write("Введите число или слово: ");
phrase();


// Задача №21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double sqwert1 (int x1, int y1, int f1, int x2, int y2, int f2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (f2-f1)*(f2-f1));
}
Console.Write("Введите координату х1 для первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y1 для первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату f1 для первой точки: ");
int f1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x2 для второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y2 для второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату f2 для второй точки: ");
int f2 = Convert.ToInt32(Console.ReadLine());

Console.Write(sqwert1(x1,y1,f1, x2,y2,f2));


// Задача № 23:Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void cubes (int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while (count <=N)
    {
        Console.Write(count*count*count + " ");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >0)
    cubes (num);
else
    Console.Write("Число должно быть от 0. Введите число: ");

*/


