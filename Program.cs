/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

void threedigitnum ()
{ 
    Console.Write("Введите трехзначное целое число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int f = num / 10; 
    int d = f % 10;   
    
        
    if (num > 999 || num < 100)
        {
        Console.Write ("Цифра не соответствует заданному диапозону");
        }
    else 
        Console.Write (num + " -> " + d);
}

threedigitnum();

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void figure (int num)
{
    int a = num%10;
    int b = (num/10)%10;
    int c = (num/100)%10;
    Console.Write(num + " -> ");

    if (num <99)
        {
         Console.Write(num + " неверно. Число не должно быть двухзначным");
        }
    else 
        {
        if (num <= 999)
        Console.Write(a);
        if (num <= 9999)
        Console.Write(b);
        if (num <= 99999)
        Console.Write(c);        
        } 
    }

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());    
figure (num);

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void week (int num_day)
{
if (num_day > 7 || num_day < 1)
    {
        Console.WriteLine("Цифра не соответствует количеству дней в неделе");
    }
else
    {
        if (num_day == 1)
            Console.WriteLine("рабочий день");
        if (num_day == 2)
            Console.WriteLine("рабочий день");
        if (num_day == 3)
            Console.WriteLine("рабочий день");
        if (num_day == 4)
            Console.WriteLine("рабочий день");
        if (num_day == 5)
            Console.WriteLine("рабочий день");
        if (num_day == 6)
            Console.WriteLine("выходной");
        if (num_day == 7)
            Console.WriteLine("выходной");
    }
}

Console.Write("Введите цифру дня недели от 1 до 7: ");
int num_day = Convert.ToInt32(Console.ReadLine());
week (num_day);
*/
