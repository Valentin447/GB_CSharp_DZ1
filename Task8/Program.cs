﻿// Задача 8: Напишите программу, которая на вход принимает число (N > 0), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число больше нуля: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 1;
while(count <= number){
    if(count % 2 == 0){
        Console.Write(count + ", ");
    }
    count++;
}