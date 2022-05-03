/*
// Задача №34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int [] RandomArray (int size, int min, int max) 
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void FindSumArray (int [] array)
{
    int count = 0;
     for (int i = 0; i < array.Length; i++)
    {
        if (array [i] %2 ==0 ) 
            count ++; 
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
}

void ScreenArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int [] myArray = RandomArray(5, 100, 400);
ScreenArray(myArray);
FindSumArray(myArray);


//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int [] RandomArray (int size, int min, int max) 

{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void FindSumArray (int [] array)
{
    int PlusSum = 0; //  создали переменную
    
    for (int i = 1; i < array.Length; i+=2)
    {
        PlusSum += array[i]; // увелич.PlusSum
    }
    Console.WriteLine("Сумма элементов на нечетных позициях: " + PlusSum);
}

void ScreenArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int [] myArray = RandomArray(7, 1, 12);
ScreenArray(myArray);
FindSumArray(myArray);


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int [] RandomArray (int size, int min, int max) 

{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void FindDifArray (int [] array)
{
    int min = 0; 
    int max = 0; 
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] > max) 
            max = array[i]; 
        else            
            min = array[i];
    }
    Console.WriteLine("Максимальный элемент: " + max); 
    Console.WriteLine("Минимальный элемент: " + min);
    Console.WriteLine("Разница между элементами: " + (max-min));
}

void ScreenArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int [] myArray = RandomArray(5, 1, 12);
ScreenArray(myArray);
FindDifArray(myArray);

*/
