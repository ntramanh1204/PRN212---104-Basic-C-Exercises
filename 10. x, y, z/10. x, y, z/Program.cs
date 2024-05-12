Console.Write("Enter first number - ");
int first = int.Parse(Console.ReadLine());
Console.Write("Enter second number - ");
int second = int.Parse(Console.ReadLine());
Console.Write("Enter third number - ");
int third = int.Parse(Console.ReadLine());

Console.WriteLine($"Result of specified nubmers {first}, {second} and {third}, (x+y).z is {(first + second) * third} and x.y + y.z is {first * second + second * third}");