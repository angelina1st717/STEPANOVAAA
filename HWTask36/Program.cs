// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Random rnd = new Random();             
int[] array = new int[4];              
int summ = 0;                          
for (int i = 0; i < array.Length; i++) 
{
    array[i] = rnd.Next(0, 99);        
    if (i % 2 != 0)                    
    {
        summ = summ + array[i];        
    }
}
var result = string.Join(", ", array);              
Console.WriteLine($"[{result}]");
Console.WriteLine($"{summ}");

