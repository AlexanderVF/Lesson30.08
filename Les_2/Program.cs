

Console.WriteLine("vvedite chislo");
int a = int.Parse(Console.ReadLine());

int count = 0;



while (a > 0)
    { 
    
        a = a / 10;
        //Console.WriteLine(a);
        count++;
    }
    
    
Console.WriteLine(count);
