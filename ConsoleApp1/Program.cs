



int[] conc = [];
int sum = 0;
for (int i = 0; i < 101; i++)
{
    Console.WriteLine("ВВедите число №" + i);
    conc[i] = int.Parse(Console.ReadLine());
    if ((conc[i] % 10 == 3) & (conc[i] % 7 == 0))
    {
        sum = sum + conc[i];
    }
    if (conc[i] == 0)
    {
        break;
    }



}
Console.WriteLine(sum);