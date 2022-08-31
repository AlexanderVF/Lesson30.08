Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());

int x = a;
int i = 0;
int sum = 0;
int n = 0;

if (a < 0)
    {
        a = (a * (-1));
    }

while (a > 0)
    { 
    
        n = a % 10;
        a = a / 10;
        sum = sum + n;
        i++;
    }
    
Console.WriteLine("Сумма цифр в числе " + x + " -> " + sum);


