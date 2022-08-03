// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// int a = 2;
// int b = 3;
// int c = 7;
// int max = a;
// if (b > a)
    // max = b;
// if (c > max)
    // max = c;
    // {
        // Console.WriteLine("c является максимальным числом");
    // }
Console.Write("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());
if (b > a)

if (c > b)
{
Console.WriteLine("Третье число максимальное");
}

