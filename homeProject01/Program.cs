﻿// Create a matrix symbols.

Console.Clear();

int ind = 0;
Console.Write("Enter a count = ");
int count = Convert.ToInt32(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.DarkGreen;

while (ind < count)
{
  int symbol = new Random().Next(1, 10);
  Console.Write(symbol + "  ");
  ind++;
}
Console.ForegroundColor=ConsoleColor.White;
