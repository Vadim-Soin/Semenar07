



Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt16(Console.ReadLine());
double[,] array = new double[rows, cols];

FillArray(array);
PrintArray(array);


void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]} \t");
        Console.WriteLine();
    }
}







