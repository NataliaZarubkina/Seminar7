//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк массива: ", "Ошибка ввода!");
int columns = GetNumberFromUser("Введите количество столбцов массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser("Введите начальное значение диапазона ", "Ошибка ввода!");
int maxValue = GetNumberFromUser("Введите конечное значение диапазона ", "Ошибка ввода!");
int userNumber1 = GetNumberFromUser("Введите номер строки: ", "Ошибка ввода!");
int userNumber2 = GetNumberFromUser("Введите номер столбца: ", "Ошибка ввода!");
int[,] array = GetArray(rows, columns, minValue, maxValue);
bool result = FindNumber(userNumber1, userNumber2, array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"[{userNumber1}, {userNumber2}] {(result ? $"= {array[userNumber1 - 1, userNumber2 - 1]}" : "-> такого числа в массиве нет")}");

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

bool FindNumber(int userNumber1, int userNumber2, int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i == userNumber1-1 && j == userNumber2-1)
                return true;
        }
    }
    return false;
}