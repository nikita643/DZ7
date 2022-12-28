// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void AvergeArray(int[,] array)
{
    
    double [] result = new double [array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == array.GetLength(0)-1){result[j] = (result[j] + array[i,j])/array.GetLength(0);}
            else{result[j] = result[j] + array[i,j];}
        }
    }
    Console.WriteLine($"{string.Join("; ", result)}");
}
int [,] array = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};
AvergeArray(array);
