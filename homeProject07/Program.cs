int[] arrayNumber = new int[10];
for (int i = 0; i < 10; i++)
{
  while (true)
  {
    int number = new Random().Next(10, 1000); // 10-999
    int summa = 0, multi = 0;
    while (number > 0)
    {
      summa += summa % 10;
      multi *= multi % 10;
      number /= 10;
    }

    if ((multi % summa) == 0)
    {
      Console.WriteLine($"число {number}");
      arrayNumber[i] = number;
      break;
    }
  }
}