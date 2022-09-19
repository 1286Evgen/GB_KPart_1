﻿/* Задача
Написать программу, которая из имеющего массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении задачи не рекомендуется пользоваться коллекциями, желательно применять  массивы.
Примеры: 
["hello", "2", "world", ":-)"] -> ["2", ":-)"];
["1234", "4567"] -> [].
*/
//////////////////////////////////////////////////////////////////////////

Console.Clear(); // очищение консоли

string[] array = {"hello", "2", "world", ":-)"}; // задали строковый массив

CosnolePrint(array); // вызов метода вывода массива на экран
Console.Write(" -> ");

//////////////////////////////////////////////////////////////////////////
// метод вывода массива на экран
void CosnolePrint(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length -1; i ++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}