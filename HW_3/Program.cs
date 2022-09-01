int[] array = new int[8];
//string arr = Console.ReadLine();
//int arr = int.Parse(Console.ReadLine());
int count = array.Length;
Console.Write(array);
Console.Write(" -> [ ");

for (int i = 0; i < count; i++)
{
    
    array[i] = new Random().Next(0, 99);
    Console.Write($"{array[i]}, ");
}
    
Console.WriteLine("]");


 






/* int [] arr = {1, 5, 4, 3, 2, 6, 7, 1};

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write(arr);
    Console.Write(" -> [ ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
   
    Console.WriteLine("]");
}


PrintArray(arr); */





/* int [] array = {1, 5, 4, 3, 2, 6, 7, 1};

int count = array.Length;
Console.Write(array);
Console.Write(" -> [ ");

for (int i = 0; i < count; i++)
{
    Console.Write($"{array[i]}, ");
}
    
Console.WriteLine("]"); */









