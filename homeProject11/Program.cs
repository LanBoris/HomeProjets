Console.Clear();

int[,] FillMatrix1(int numRows, int numCols)
{
  int[,] outputMatrix = new int[numRows, numCols];
  for (int i = 0; i < numRows; i++)
  {
    for (int j = 0; j < numCols; j++)
    {
      outputMatrix[i, j] = new Random().Next(1, 1000);
    }
  }
  return outputMatrix;
}

int[,] FillMatrix2(int numRows, int numCols, int minValue, int maxValue)
{
  int[,] outputMatrix = new int[numRows, numCols];
  for (int i = 0; i < numRows; i++)
  {
    for (int j = 0; j < numCols; j++)
    {
      outputMatrix[i, j] = new Random().Next(minValue, maxValue);
    }
  }
  return outputMatrix;
}

void PrintMatrix(int[,] inputMatrix)
{
  int rowsCount = inputMatrix.GetLength(0);
  int colsCount = inputMatrix.GetLength(1);
  Console.WriteLine("\n" + "Получившийся двумерный массив: ");
  for (int i = 0; i < rowsCount; i++)
  {
    for (int j = 0; j < colsCount; j++)
    {
      Console.Write(inputMatrix[i, j] + "  ");
    }
    Console.WriteLine();
  }
}

int CheckRowsCols(int number)
{
  while (number <= 0)
  {
    Console.WriteLine("Вы ввели отрицательное число или 0.");
    Console.Write("Введите другое число: ");
    number = Convert.ToInt32(Console.ReadLine());
  }
  return number;
}

void SumEveryRow(int[,] inputMatrix)
{
  for (int i = 0; i < inputMatrix.GetLength(0); i++)
  {
    int sum = 0;
    for (int j = 0; j < inputMatrix.GetLength(1); j++)
    {
      sum+=inputMatrix[i,j];
    }
    Console.WriteLine($"Summ row {i+1}: {sum}");
  }
}

void SumEveryCol(int[,] inputMatrix)
{
  for (int i = 0; i < inputMatrix.GetLength(1); i++)
  {
    int sum = 0;
    for (int j = 0; j < inputMatrix.GetLength(0); j++)
    {
      sum+=inputMatrix[j,i];
    }
    Console.WriteLine($"Summ column {i+1}: {sum}");
  }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
rows = CheckRowsCols(rows);
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
columns = CheckRowsCols(columns);
int[,] matrix = new int[rows, columns];
Console.Write("Каким способом вы хотите заполнить массив?"
              + "\n" + "1. Случайными числами от 1 до 999."
              + "\n" + "2. Введя минимальное и максимальное значение интервала."
              + "\n" + "Нажмите 1 или 2: ");
int answerOne = Convert.ToInt32(Console.ReadLine());
while ((answerOne < 1) || (answerOne > 2))
{
  Console.WriteLine("Такого варианта нет." + "\n" + "Введите свой ответ снова: ");
  answerOne = Convert.ToInt32(Console.ReadLine());
}
if (answerOne == 1) matrix = FillMatrix1(rows, columns);
else if (answerOne == 2)
{
  Console.Write("Введите минимальное значение интервала: ");
  int minValue = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите максимальное значение интервала: ");
  int maxValue = Convert.ToInt32(Console.ReadLine());
  matrix = FillMatrix2(rows, columns, minValue, maxValue);
}


Console.Write("\n" + "Какое действие вы хотите выполнить с данным массивом?:" 
                   + "\n" + "1. Найти сумму элементов по строкам."
                   + "\n" + "2. Найти сумму элементов по столбцам."
                   + "\n" + "3. Найти сумму всех элементов массива."
                   + "\n" + "4. Найти среднее арифметическое всех элементов массива."
                   + "\n" + "5. Найти максимальный и минимальный элемент массива."
                   + "\n" + "Введите цифру от 1 до 5: ");
int answerTwo = Convert.ToInt32(Console.ReadLine());
while ((answerTwo<1) || (answerTwo>5))
{
  Console.WriteLine("Такого варианта нет." + "\n" + "Введите свой ответ снова: ");
  answerTwo = Convert.ToInt32(Console.ReadLine());
}
PrintMatrix(matrix);
if (answerTwo == 1) SumEveryRow(matrix);
if (answerTwo == 2) SumEveryCol(matrix);
