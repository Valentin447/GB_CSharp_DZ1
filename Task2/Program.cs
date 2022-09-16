// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if(a < b){
    Console.WriteLine($"Второе число ({b}) больше.");
} else if(a > b) {
    Console.WriteLine($"Первое число ({a}) больше.");
} else {
    Console.WriteLine("Числа равны!");
}
