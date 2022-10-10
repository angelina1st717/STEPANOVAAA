// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Random rnd = new Random();
int[] array = new int[4];
int count = 0;
for(int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(99, 999);
    if((array[i] % 2) == 0)
    count ++;
}
var result = string.Join(", ", array);
Console.WriteLine($"[{result}]");
Console.WriteLine($"{count}");