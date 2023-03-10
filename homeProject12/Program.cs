
var random = new Random();
int[] array = Enumerable.Range(10,90).OrderBy(t => random.Next()).ToArray();
Console.WriteLine(String.Join("; ", array));
