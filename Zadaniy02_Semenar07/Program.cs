

Console.WriteLine("Введите число");
int rows = Convert.ToInt16(Console.ReadLine());

int[,] array = new int[4, 4];
Console.WriteLine();
FillArray(array);
PrintArray(array);
Console.WriteLine();
CheckArray(array, rows);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
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


void CheckArray(int[,] array, int num)
{
    string check = $"{num} такого числа в массиве нет";
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i, j])
                check = $"{array[i, j]} положение {i},{j}";
        }
    Console.WriteLine(check);
}














