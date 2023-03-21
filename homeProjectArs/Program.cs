

// Генератор математических примеров!
Console.Clear();
Console.Write("Введите нужное количество примеров: ");
int count = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение интервала чисел: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение интервала чисел: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int number1 = 0;
int number2 = 0;
int operation = 0;
string op = String.Empty;
int[] answers = new int[count];
for (int i = 0; i < count; i++)
{
  Console.ForegroundColor = ConsoleColor.Yellow;
  int temp = 0;
  operation = new Random().Next(1, 4);
  if (operation == 1)
  {
    op = "+";
    number1 = new Random().Next(minValue, maxValue);
    number2 = new Random().Next(minValue, maxValue);
    Console.WriteLine($"Пример №{i + 1}: {number1}{op}{number2}");
    temp = number1 + number2;
  }
  else if (operation == 2)
  {
    op = "-";
    number1 = new Random().Next(minValue, maxValue);
    number2 = new Random().Next(minValue, maxValue);
    if (number1 >= number2)
    {
      Console.WriteLine($"Пример №{i + 1}: {number1}{op}{number2}");
      temp = number1 - number2;
    }
    else if (number1 <= number2)
    {
      Console.WriteLine($"Пример №{i + 1}: {number2}{op}{number1}");
      temp = number2 - number1;
    }
  }
  else if (operation == 3)
  {
    op = "*";
    number1 = new Random().Next(minValue, maxValue);
    number2 = new Random().Next(minValue, maxValue);
    Console.WriteLine($"Пример №{i + 1}: {number1}{op}{number2}");
    temp = number1 * number2;
  }
  else if (operation == 4)
  {
    op = "/";
    number1 = new Random().Next(minValue, maxValue);
    number2 = new Random().Next(minValue, maxValue);
    if (number1 >= number2)
    {
      Console.WriteLine($"Пример №{i + 1}: {number1}{op}{number2}");
      temp = number1 / number2;
    }
    else if (number1 <= number2)
    {
      Console.WriteLine($"Пример №{i + 1}: {number2}{op}{number1}");
      temp = number2 / number1;
    }
  }
  answers[i] = temp;
}
Console.WriteLine("\n" + "Чтобы получить ответы на прмиеры, нажмите Enter.");
Console.ReadKey();
Console.WriteLine("\n" + $"Ответы: {String.Join("; ", answers)}");
Console.ForegroundColor = ConsoleColor.White;
Console.ReadKey();
