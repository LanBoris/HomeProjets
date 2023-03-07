Console.Clear();

// Генератор математических примеров!

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
for (int i = 0; i < count; i++)
{
  operation = new Random().Next(1, 3);
  if (operation == 1) op = "+";
  else if (operation == 2) op = "-";
  number1 = new Random().Next(minValue, maxValue);
  number2 = new Random().Next(minValue, maxValue);
  if (number1>=number2) Console.WriteLine($"Пример №{i+1}: {number1}{op}{number2}");
  else if (number1<=number2) Console.WriteLine($"Пример №{i+1}: {number2}{op}{number1}");
}

