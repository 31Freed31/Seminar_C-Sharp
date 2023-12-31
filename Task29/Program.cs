﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size] ;
    Random rnd = new Random(8) ;
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1 ,100) ;
    }
    return array ;
}

void PrintArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " " ) ;
    }
}

int[] arr = CreateArray(8) ;
PrintArray(arr) ;