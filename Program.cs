﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, 
// которая покажет количество чётных чисел в массиве.
/*
Console.WriteLine("Задача 34");
int[] numbers = new int [7];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
CounterEvenNumber(numbers);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

void CounterEvenNumber(int[] number)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if (number[i] % 2 == 0)
        {
            count += 1;
        }
    }
    Console.WriteLine($" -> колличество четных чисел в массиве равно: {count}");
}

void OutputArrayString(int[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.Write($"Массив: {stringArray}");
}
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Задача 36");

int[] numbers = new int[4];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
SumStandingElementsOddPositions(numbers);

void FillArray(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = rnd.Next(-50, 50);
    }
}

void OutputArrayString(int[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.Write($"Массив: {stringArray}");
}

void SumStandingElementsOddPositions(int[] number)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 != 0)
        {
            sum += number[i];
        }
    }
    Console.WriteLine($" -> сумма чисел стоящих на нечётных позициях " +
                      $"в массиве равна: {sum}");
}
*/
//Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.WriteLine("Задача 36");
double[] numbers = new double [10];
int n = numbers.Length;

FillArray(numbers);
OutputArrayString(numbers);
DifferenceМinМax(numbers);

void FillArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < n; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * 100);
    }
}

void DifferenceМinМax(double[] number)
{
    double min = number[0];
    double max = number[0];
    for (int i = 0; i < n; i++)
    {
        if (number[i] > max)
        {
            max = number[i];
        }
        if (number[i] < min)
        {
            min = number[i];
        }
    }
    double diff = max - min;
    Console.WriteLine($" -> разница между максимальным элементом {max} " +
                      $"и минимальным элементом {min} массива равна: {diff}");
}

void OutputArrayString(double[] arrayString)
{
    string stringArray = "[";

    for (int i = 0; i < arrayString.Length; i++)
    {
        stringArray += $"{arrayString[i]}, ";
    }
    int n = stringArray.Length;
    stringArray = stringArray.Remove(n - 2, 2);
    stringArray += "]";
    Console.Write($"Массив: {stringArray}");
}