// Поиск максимального и минимального элементов массива и их индексов.
// Массив заполняется рандомно.

Console.Clear();
void FillArray(int[] ar)
{
  int len = ar.Length;
  int ind = 0;
  while (ind < len)
  {
    ar[ind] = new Random().Next(1, 100);
    ind++;
  }
}

void PrintArray(int[] arr)
{
  int leng = arr.Length;
  int inde = 0;
  while (inde < leng)
  {
    Console.Write(arr[inde] + " ");
    inde++;
  }
}

int Max(int[] ar)
{
  int max = 0;
  int lengar = ar.Length;
  int index = 0;
  while (index < lengar)
  {
    if (ar[index] > max)
    {
      max = ar[index];
    }
    index++;
  }
  return max;
}

int Min(int[] ar)
{
  int min = ar[0];
  int lengarr = ar.Length;
  int indd = 0;
  while (indd < lengarr)
  {
    if (ar[indd] < min)
    {
      min = ar[indd];
    }
    indd++;
  }
  return min;
}

int IndexOf(int[] ar, int find)
{
  int count = ar.Length;
  int innd = 0;
  int position = -1;

  while (innd < count)
  {
    if (ar[innd] == find)
    {
      position = innd;
    }
    innd++;
  }
  return position;
}

Console.Write("Enter length of an array = ");
int arrayLength=Convert.ToInt32(Console.ReadLine());

int[] array = new int[arrayLength];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int maximum = Max(array);
int pos = IndexOf(array, maximum);
int minimum = Min(array);
int poss = IndexOf(array, minimum);
Console.WriteLine("Maximum = " + maximum);
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine("Index of maximum = " + pos);
Console.ForegroundColor=ConsoleColor.White;
Console.WriteLine("Minimum = " + minimum);
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine("Index of minimum = " + poss);
Console.ForegroundColor=ConsoleColor.White;
