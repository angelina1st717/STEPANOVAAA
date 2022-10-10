// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Write("Введите 8 элементов массива: ");
{  
    int[] array = new int[8]; 
    int i;  
    for(i=0; i<8; i++)  
    {  
	    array[i] = Convert.ToInt32(Console.ReadLine());  		
    }   
     Console.WriteLine($"[{String.Join(",",array)}]");
}
   
