Console.WriteLine("Input first integer:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Input second integer:");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Input third integer:");
int third = int.Parse(Console.ReadLine());
int[] arr = {first, second, third };
Console.WriteLine($"Largest of three: {arr.Max()}");
Console.WriteLine($"Lowest of three: {arr.Min()}");