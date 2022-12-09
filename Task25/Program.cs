// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243

// 2, 4 -> 16

Console.WriteLine("Введите число А:");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В (натуральное):");
double b = Convert.ToInt32(Console.ReadLine());

if (b < 0) Console.WriteLine("Число В не является натуральным");
else Console.WriteLine($"{a}, {b} -> {Exponentiation(a, b)}");


double Exponentiation(double n1, double n2)
{
    return Math.Pow(n1, n2);
}


