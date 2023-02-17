Console.Clear();
Console.Write("N: ");
int N=Convert.ToInt32(Console.ReadLine());

while (N<=0)
{
  Console.Write("New N: ");
  N=Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(Math.Pow(N, 3));
