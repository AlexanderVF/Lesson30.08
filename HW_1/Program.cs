Console.Clear();
Console.WriteLine("Введите число A");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B");
int b = int.Parse(Console.ReadLine());

int i = 0;

while (i == 0 )
{
    Console.Write(a + ", " + b + " -> " + Math.Pow(a, b));
        i++;
}