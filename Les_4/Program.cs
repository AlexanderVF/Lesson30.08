
Console.WriteLine("vvedite chislo");
int a = int.Parse(Console.ReadLine());

int i = 1;
int pr = 1;

while (a <= 0)
{
Console.WriteLine(a* (i+1));
i++;
}

pr = pr * i;
Console.WriteLine(pr);