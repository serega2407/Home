﻿/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
14-> нет 
46-> нет
161-> да
*/

Console.WriteLine("Введите число: ");
int Num1=Convert.ToInt32(Console.ReadLine());
if (Num1 % 7 ==0 && Num1 % 23 ==0)
{
    Console.WriteLine($"Число {Num1} кратно 7 и 23");
}
else
{
    Console.WriteLine($"Число {Num1} не кратно 7 и 23");
}