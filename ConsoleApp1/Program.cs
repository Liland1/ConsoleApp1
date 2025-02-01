class Program
{
    static void Main()
    {
        int x, y; //координаты игрока
        string[][] field = [new string[3], new string[3], new string[3]]; //игровое поле
        x = int.Parse(Console.ReadLine()); //ввод
        y = int.Parse(Console.ReadLine());
        field[x][y] = "X";
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(field[i][j]);
            }
            Console.Write("\n");
        }
    }
}