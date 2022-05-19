/*
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] a = new double[3, 4];
Random random = new Random();
    
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            a[i, j] = random.NextDouble()*100;
            Console.Write("{0,6:F2}", a[i, j]);
        }
    Console.WriteLine();
    }



// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

int ArrayPossition(int[,] ar)
{
   Console.Write("Введите номер строки: ");
   int a = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите номер столбца: ");
   int b = Convert.ToInt32(Console.ReadLine());
   Console.Write("Введите число: ");
   int number = Convert.ToInt32(Console.ReadLine());

    if (ar[a,b] == number)
        Console.Write(number + "\t" + "Данное число есть в матрице");
    else
        Console.Write(number + "->" + "Данное число отсутствует в матрице");
    return number;   
}



Console.Write("Введите кол-во строк и столбцов (матрицу): ");
int size = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [size, size]; 

for (int i = 0; i < matrix.GetLength(0); i++) 
{   for (int j = 0; j < matrix.GetLength(1); j++)
   {
       matrix[i,j] = new Random().Next(0,10); 
       Console.Write(matrix[i,j] + " ");
   } 
    Console.WriteLine(); 
}

Console.WriteLine(ArrayPossition(matrix)); //вызвали метод, который на вход взяла нашу матрицу
*/

//Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

double[,] ArithmeticInColumn(int[,] ar)
{
    int sum = 0;
    double result = 0;
    
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        
        for (int j = 0; j< ar.GetLength(1); j++)
        {
            sum *= ar[i,j];
            result = sum/ar.GetLength(0);            
        }
    }
    return result;   
}



Console.Write("Введите кол-во строк и столбцов (матрицу): ");
int size = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [size, size]; 

for (int i = 0; i < matrix.GetLength(0); i++) 
{   for (int j = 0; j < matrix.GetLength(1); j++)
   {
       matrix[i,j] = new Random().Next(0,10); 
       Console.Write(matrix[i,j] + " ");
   } 
    Console.WriteLine(); 
}

Console.WriteLine(ArithmeticInColumn(matrix));
