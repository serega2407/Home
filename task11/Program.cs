﻿/* Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
Если второе число некратно первому, то программа выводит остаток от деления.
34, 5->некратно, остаток 4
16, 4->Кратно 
*/
System.Console.Write("Введите 1 число - ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите 2 число - ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber % secondNumber;

if (result ==0)
    Console.WriteLine("Кратно");
else
    Console.WriteLine(result);
