
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt16(Console.ReadLine());
int[,] array = new int[rows, cols];


Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
SortArray(array);
PrintArray(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(0, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}


void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int x = 0; x < array.GetLength(0); x++)
            {
                for (int y = 0; y < array.GetLength(1); y++)
                    if (i > x || j > y)
                        if (array[i, j] < array[x, y])
                            (array[i, j], array[x, y]) = (array[x, y], array[i, j]);
            }
    }
}








