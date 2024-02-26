using System;

class ArrayMethods
{
  
    public static void Add()
    {
        int[] arr = new int[10]; 
        int count = 0; 

        Console.WriteLine("Ededler daxil edin,daxil etmeyi bitirmek ucun hecne yazmadan entere basin");

        while (true) 
        {
            if (count == arr.Length) 
            {
                int[] yeni_array = new int[arr.Length * 2]; 
                Array.Copy(arr, yeni_array, arr.Length); 
                arr = yeni_array; 
            }

            string input = Console.ReadLine(); 
            if (string.IsNullOrWhiteSpace(input)) 
                break;

            if (int.TryParse(input, out int number)) 
            {
                arr[count] = number; 
                count++; 
            }
            else
            {
                Console.WriteLine("Eded yazmalisiniz"); 
            }
        }

        Console.WriteLine("Arraydeki ededler:"); 
        for (int i = 0; i < count; i++) 
        {
            Console.Write(arr[i] + " ");
        }
    }
}
namespace MyProgram
{
    class MetodYoxlamalari
    {
        static void Main(string[] args)
        {
            ArrayMethods.Add();
        }
    }
}  