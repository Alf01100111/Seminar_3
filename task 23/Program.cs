System.Console.WriteLine("ВВедите число ");
int number = Convert.ToInt32(Console.ReadLine());

void CubeTable(int num)
{
    for (int i = 1; i <= num; i++)
    {
        int result = i * i * i;
        Console.Write($"{result},");
    }
    Console.Write("\b\b");
}

CubeTable(number);
