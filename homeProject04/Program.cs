// Замена цифры в строке на 0 или 1

Console.Clear();
Console.Write("Введите строку цифр: ");
string x = Console.ReadLine()!;
string str = "";
foreach (char s in x)
{
  if (s < '5') str += '0';
  else str += '1';
}
Console.WriteLine(str);
