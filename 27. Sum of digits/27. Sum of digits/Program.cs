Console.Write("Input a number (integer): ");
string num = Console.ReadLine();
int sum = 0;
foreach (char c in num)
{
    sum += int.Parse(c.ToString());
}
Console.WriteLine($"Sum of the digits of the said integer: {sum}");
