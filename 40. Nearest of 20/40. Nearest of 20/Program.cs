Console.WriteLine("Input first integer:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Input second integer:");
int second = int.Parse(Console.ReadLine());

int firstDistance = Math.Abs(first - 20);
int secondDistance = Math.Abs(second - 20);
if (firstDistance < secondDistance) Console.WriteLine(first);
else if (secondDistance < firstDistance) Console.WriteLine(second);
else Console.WriteLine(0);