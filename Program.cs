
﻿// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] ReadUserInput(int size_of_array)
{
    string[] arrayOfStrings = new string[size_of_array];
    for (int i = 0; i < size_of_array; i ++)
    {
       arrayOfStrings[i] = Convert.ToString(Console.ReadLine());
    }
    return arrayOfStrings;
}

void PrintArray(string[] arrayOfStrings)
{
    Console.Write("[");
    for (int i = 0; i < arrayOfStrings.Length; i ++)
    {
        if (i != arrayOfStrings.Length - 1)
        {
            Console.Write($"{arrayOfStrings[i]} ");
        }
        else
        {
            Console.Write($"{arrayOfStrings[i]}");
        }
        
        // Console.Write($"{arrayOfStrings[i], 4}");
    }
    Console.Write("]");
}

int CountStringsEquals3Symbols(string[] arrayOfStrings)
{
    int counter = 0;
    for (int i = 0; i < arrayOfStrings.Length; i++)
    {
        if (arrayOfStrings[i].Length <= 3)
        {
            counter ++;
        }
    }
    return counter;
}

string[] CheckNumOfSymbols(string[] arr_new)
{
    string[] new_array = new string[CountStringsEquals3Symbols(arr_new)];
    int j = 0;
    for (int i = 0; i < arr_new.Length; i ++)
    {
        if (arr_new[i].Length <= 3)
        {
            new_array[j] = arr_new[i];
            j ++;
        }
    }
    return new_array;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
if (size <= 0)
{
    Console.WriteLine("Ошибка. Необходимо ввести натуральное число. ");
    Environment.Exit(0);
}

Console.WriteLine("Начните вводить элементы массива - строки. После каждой строки необходимо нажать Enter.");
string[] array = ReadUserInput(size);

Console.WriteLine("Полученный массив строк: ");
PrintArray(array);

Console.WriteLine("\nРезультат преобазования массива: ");
PrintArray(CheckNumOfSymbols(array));

// string[] result = CheckNumOfSymbols(array);
// PrintArray(result);
