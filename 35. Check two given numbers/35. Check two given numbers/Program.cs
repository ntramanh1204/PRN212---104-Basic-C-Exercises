Console.Write("Input a first number (<100): ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input a second number (>100): ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine(first < 100 && second > 100);