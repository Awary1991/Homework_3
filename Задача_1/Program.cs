//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
if (num[0] == num[4] & num[1] == num[3])
    {
        Console.WriteLine("Это полиндром");
    }
else 
    Console.WriteLine("не полиндром");