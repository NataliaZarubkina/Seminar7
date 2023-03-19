//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите начальное значение диапазона ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите конечное значение диапазона ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);
PrintResult(array);

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintResult(int[,] inArray)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    double result;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        result = 0;
        for (int j = 0; j < inArray.GetLength(0); j++)
        {
           result += inArray[j,i];           
        }
        result = Math.Round(result/ inArray.GetLength(0), 2);
        Console.Write($"{result}; ");       
    }
}