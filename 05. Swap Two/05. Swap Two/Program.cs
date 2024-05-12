using System.Runtime.ExceptionServices;

Console.Write("Input the First Number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input the Second Number: ");
int second = int.Parse((Console.ReadLine()));

int temp = first;
first = second;
second = temp;

Console.WriteLine("After Swapping:");
Console.WriteLine($"First number: {first}");
Console.WriteLine($"Second number: {second}");