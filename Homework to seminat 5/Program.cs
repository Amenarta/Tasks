/*
// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

double Degree (double a, double b)
{
    double sum = 0;    
        if (a ==0 || b==0) return 0;
    else 
        sum = Math.Pow(a, b);       
    return sum;    
}

Console.Write("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число В: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Число А в натуральной степени числа В равно: " + Degree(num1, num2));


//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void SumOfNumbers (int a)
{
    int sum = 0;
    int m = 0;
    while (a > 0)
    {
        m = a % 10;
        sum += m; 
        a = a/10;
    }
    Console.WriteLine("Сумма цифр в числе: " + sum);
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
SumOfNumbers(num);


// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] Array (int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
        
    }
    return array;
}

void ScreenArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write("{" + array[i] + "}");
    Console.WriteLine();
    
}

int[] myArray = Array(8, 0, 25);
ScreenArray(myArray);
*/
