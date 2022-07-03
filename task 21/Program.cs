
int[] CoordEnter(string dotname)
{
    System.Console.WriteLine($"Введите координаты точки {dotname} (X, Y, Z)");
    int[] resultarr = new int[3];
    for (int i = 0; i < resultarr.Length; i++)
    {
        resultarr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return resultarr;
}

// void PrintArr(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($" {arr[i]}");
//     }
// }

int Distance(int[] dot1, int[] dot2)
{
    int[] deltas = new int[3];
    for (int i = 0; i < 3; i++)
    {
        deltas[i] = dot1[i] - dot2[i];
    }
    double result = Math.Sqrt(Math.Pow(deltas[0], 2) + Math.Pow(deltas[1], 2) + Math.Pow(deltas[2], 2));
    return result;
}


int[] dotcoordA = CoordEnter("A");
int[] dotcoordB = CoordEnter("B");

System.Console.WriteLine(Distance(dotcoordA,dotcoordB));

PrintArr(dotcoordA);

