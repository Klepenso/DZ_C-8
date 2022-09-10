// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void MinRow(int[,] array)
{
    int minsum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        minsum += array[0, j];
    }
    Console.WriteLine($"Сумма строки 1 = {minsum}");
    int row = 0;
    int sum = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма строки {i + 1} = {sum}");
        if (sum < minsum)
        {
            minsum = sum;
            row = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой - {row + 1}");
}

int[,] array = CreateRandom2DArray(6, 4, 0, 10);
Print2DArray(array);
MinRow(array);
