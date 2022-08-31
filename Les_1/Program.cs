

int GetSumNums(int number) {
    int sum = 0;
    for (int i = 1; i <= number; ++i) {
        sum += i;
        
    }
    return sum;
    //Console.WriteLine(sum);
}

Console.WriteLine("vvedite chislo");
int a = int.Parse(Console.ReadLine());

Console.WriteLine(GetSumNums(a));