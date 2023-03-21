
// var random = new Random();
// int[] array = Enumerable.Range(10, 90).OrderBy(t => random.Next()).ToArray();
// Console.WriteLine(String.Join("; ", array));

// int[] array = { 1, 3, 4, 5, 4, 2 };
// int item = 4;
// array = Array.FindAll(array, i => i != item).ToArray();
// Console.WriteLine(String.Join(",", array));

int[] array = { 1, 3, 4, 5, 4, 33, 44, 12, 13, 4, 2 };
int item = 4;
array = array.Where(e => e != item).ToArray();
Console.WriteLine(String.Join(",", array));