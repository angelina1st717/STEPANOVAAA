// Напишите программу, которая на вход принимает два числа и 
// выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

{
Console.Write("Введи два числа и я тебе покажу какое из них больше.");
int a, b;
Console.WriteLine("Введите первое целое число: ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
b = Convert.ToInt32(Console.ReadLine());

bool x = a > b;
bool y = a < b;
bool z = a == b; 
if (x)
{
  Console.WriteLine($"{a}");  
}
else if (y)
{
    Console.WriteLine($"{b}");
}
else if (z)
{
    Console.WriteLine($"равны");
}
}