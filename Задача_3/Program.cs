//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");

int a = int.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    Console.WriteLine(i * i * i);
}