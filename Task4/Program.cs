// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите третье число: ");
int n3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(n1 < n2){
    if(n2 < n3){
        Console.WriteLine($"Третье число ({n3}) максимальное");
    } else {
        Console.WriteLine($"Второе число ({n2}) максимальное");
    }   
} else {
    if(n1 < n3){
        Console.WriteLine($"Третье число ({n3}) максимальное");
    } else {
        Console.WriteLine($"Первое число ({n1}) максимальное");
    }
}