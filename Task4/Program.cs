/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Clear();
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int count=1;
while(count <= n)
{
    if (count%2==0) // без этого кода выводит все числа вообще, а не только четные, а с ним проблемы с запятыми и точкой
{
    Console.Write(count);
    if (count<n)
    {
        Console.Write (", ");
    }
    else if (count==n)
    {
    Console.WriteLine (".");
    }
}
    count++;
}
