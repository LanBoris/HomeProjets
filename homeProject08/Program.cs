// Find a century

Console.Write("Enter a year: ");
int year=Convert.ToInt32(Console.ReadLine());

int century = (year - 1) / 100 + 1;

Console.WriteLine($"Century - {century}");
