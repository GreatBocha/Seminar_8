void Task56()
{
    // Задача 56: Задайте прямоугольный двумерный массив. 
    // Напишите программу, которая будет находить строку с наименьшей суммой элементов.
    // Программа считает сумму элементов в каждой строке и выдаёт
    //  номер строки с наименьшей суммой элементов: 1 строка


    Random plsNoCube = new Random();
    int rows = plsNoCube.Next(2, 7);
    int columns = plsNoCube.Next(2, 7);
    if (rows == columns) { columns++; }
    int[,] matrix = new int[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine($"Наименьшая сумма элементов у {LowSummElements(matrix)}й строки масива");
}

int LowSummElements(int[,] arr)
{
    int rowsSize = arr.GetLength(0);
    int columnsSize = arr.GetLength(1);
    int minSummRow = 0;
    int sumRowElements = 0;
    for (int j = 0; j < columnsSize; j++)
    {
        sumRowElements = sumRowElements + arr[0, j];
    }
    int MinSumm = sumRowElements;
    for (int i = 1; i < rowsSize; i++)
    {
        sumRowElements = 0;
        for (int j = 0; j < columnsSize; j++)
        {
            sumRowElements = sumRowElements + arr[i, j];
        }
        if (sumRowElements < MinSumm)
        {
            MinSumm = sumRowElements;
            minSummRow = i + 1;
        }
    }
    return minSummRow;
}