Console.WriteLine("Input first integer:");
int first = int.Parse(Console.ReadLine());
Console.WriteLine("Input second integer:");
int second = int.Parse(Console.ReadLine());
Console.WriteLine("Check if one is negative and one is positive:");
if ((first > 0 && second < 0) ||  (first < 0 && second > 0))
{
    Console.WriteLine("True");
} else
{
    Console.WriteLine("False");
}