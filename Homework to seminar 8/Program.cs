/*
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию
// элементы каждой строки двумерного массива.

int[,] GrowthArray(int[,] array)
{
    int temp = 0;
    
    for (int j=0; j < array.GetLength(1); j++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i,j]> array[i,j+1])
                {
                    temp = array[i,j];
                    array[i,j] = array[i,j+1];
                    array[i,j+1] = temp;
                    Console.Write(array[i,j] + " ");
                }
            }
            Console.WriteLine();
        }
        
    return array;
}


Console.Write("Введите кол-во строк и столбцов (матрицу): ");
int size = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [size, size]; // объявляем 2-хмерный массив

for (int i = 0; i < matrix.GetLength(0); i++) // прописываем цикл в цикле
{   for (int j = 0; j < matrix.GetLength(1); j++)
   {
       matrix[i,j] = new Random().Next(0,10); // заполняем массив случ.цифрами
       Console.Write(matrix[i,j] + " ");
   } 
    Console.WriteLine(); // отделяем строку
}

Console.WriteLine(GrowthArray(matrix)); 


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreatArray(int m, int n) // задаем любой массив, не только квадратный
{
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j  = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] StringSum(int[,] matrix)
{
    
    int sum = 0;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {   int temp = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            temp += matrix[i,j];
            if (temp < sum)
                {
                    sum = temp;
                    index = i;
                }
        Console.WriteLine("Строка: " + index + " Сумма - " + sum);
        }
    return matrix;
    }
}   

Console.Write("Введите кол-во строк матрицы: ");
int strin = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов матрицы: ");
int colum = Convert.ToInt32(Console.ReadLine());

PrintArray(StringSum(CreatArray(strin,colum))); 

*/