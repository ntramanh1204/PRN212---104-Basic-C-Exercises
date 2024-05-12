Console.Write("Input a first number: ");
int first = int.Parse(Console.ReadLine());
Console.Write("Input a second number: ");
int second = int.Parse(Console.ReadLine());
Console.WriteLine((first >= -10 && first <= 10) || (second >= -10 && second <= 10));