﻿// Как попривестствовать пользователя - любимчика?
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
