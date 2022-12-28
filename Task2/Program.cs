// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
void FindNumber(int[,] array, int number)
{
    int position = array.GetLength(0)*array.GetLength(1);
    int temp = 0;
    int [] result = new int [position];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[temp] = array[i,j];
            temp++;
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine("");
    }
    Console.Write("");
    if(result.Length - 1 >= number){{Console.WriteLine($"{result[number]} -> такое число есть массиве");}    }
    else{Console.WriteLine($"{number} -> такого числа в массиве нет");}
    }
int EnterNumber(string text)
{
    
    Console.Write(text);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int number = EnterNumber("Введите позицию элемента которую необходимо найти: ");
int [,] array = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};

FindNumber(array,number);