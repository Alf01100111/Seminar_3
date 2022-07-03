
double[] CoordEnter(string dotname)                   //метод для ввода координат 
{
    System.Console.WriteLine($"Введите координаты точки {dotname} (X, Y, Z)");
    double[] resultarr = new double[3];
    for (int i = 0; i < resultarr.Length; i++)
    {
        resultarr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return resultarr;
}

double Distance(double[] dot1, double[] dot2)
{
    double[] deltas = new double[3];
    for (int i = 0; i < 3; i++)
    {
        deltas[i] = dot1[i] - dot2[i];
    }
    double result = Math.Sqrt(Math.Pow(deltas[0], 2) + Math.Pow(deltas[1], 2) + Math.Pow(deltas[2], 2));       //Считаем по формуле аналогичной Пифагору
    return result;
}


double[] dotcoordA = CoordEnter("A");
double[] dotcoordB = CoordEnter("B");
System.Console.Write("Расстояние между точками - ");
System.Console.WriteLine(Distance(dotcoordA,dotcoordB));