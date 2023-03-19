//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите начальное значение диапазона ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите конечное значение диапазона ", "Ошибка ввода!");
double[,] array = GetArray(rows, columns, minValue, maxValue);
PrintArray(array);


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

double [,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void PrintArray(double[,] inArray)
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
