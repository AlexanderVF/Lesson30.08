int[] array = new int[8];
int i = 0;
for (i = 0; i < 8; i++)
{
    array[i] = new Random().Next(0, 2);
}

i = 0;
while (i < 8)
{
    Console.Write(array[i]);
    i++;
}


