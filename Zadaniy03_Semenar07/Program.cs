

Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt16(Console.ReadLine());
int[,] array = new int[rows, cols];


Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
ArifArray(array);
Console.WriteLine();

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


void ArifArray(int[,] array)
{
    double[] sum = new double[array.GetLength(1)];
    Console.Write("Среднее арифметическое каждого столбца:");

    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum[j] = array[i, j] + sum[j];
            if (i == array.GetLength(0) - 1)
                sum[j] = Math.Round(sum[j] / array.GetLength(0), 1);
        }
        Console.Write($" {sum[j]} ");
    }
}




















