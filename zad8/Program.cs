/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
*/
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int even = 2;

while (num >= even)
{
    Console.Write(even + " ");
    even = even + 2;
}