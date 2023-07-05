// 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Console.Write("Введите количество строк массива: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[row, column];
Console.Write("Введите позицию строки: ");
int row2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию столбца: ");
int column2 = Convert.ToInt32(Console.ReadLine());
void mas(int row, int column)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < row; i++)
    {
        Console.WriteLine();
        for (j = 0; j < column; j++)
        {
            randomArray[i, j] = rand.Next(0, 10);
            Console.Write($"{randomArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

mas(row, column);
if (row2 < 1 || column2 < 1)
    Console.WriteLine("Позиции не могут быть отрицательными");
else if (row2 <= row + 1 && column2 <= column + 1)
    Console.WriteLine($"Значение элемента равно {randomArray[row2 - 1, column2 - 1]}");
else Console.WriteLine($"Такого элемента нет в массиве");
