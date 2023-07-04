// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[row,col];

void mas(int row, int col)
{
    int i;
    int j;
    Random rand = new Random();
    for (i = 0; i < row; i++)
    {
        Console.WriteLine();
        for (j = 0; j < col; j++)
        {
            randomArray[i,j] = rand.Next(1,9);
            Console.Write($"{randomArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void summa(int row, int col)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i;
    int j;
    Random rand = new Random();
    for (j = 0; j < col; j++)
    {
        double sum = 0;
        for (i = 0; i < row; i++)
        {
            sum = sum + randomArray[i,j];
        }
        Console.Write($"{sum/(i):F1}; ");
    }
}
mas(row,col);
summa(row,col);