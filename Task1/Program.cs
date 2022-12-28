// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
void DimensArray(int m, int n)
{
    double [,] array = new double [m, n];
    Random rnd = new  Random();
    for (int i = 0; i < m; i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < n; j++)
        {
            array[i,j] = Convert.ToDouble(rnd.Next(-100, 100)/10.0);
            Console.Write($"{array[i, j]} ");
        }
    }
}
int EnterSize(string text)
{
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
double [,] array = {};
int m = EnterSize("ВВедите m: ");
int n = EnterSize("ВВедите n: ");
DimensArray(m, n);