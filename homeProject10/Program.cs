Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = Convert.ToString(number, 2);
Console.WriteLine($"В двоичной системе счисления это: {result}");
