Console.Write("Input a string (contains at least one 'w' char): ");
string str = Console.ReadLine();
int count = 0;
foreach (char c in str)
{
    if (c == 'w') count++;
}
Console.WriteLine("Test the string contains 'w' character between 1 and 3 times:");
Console.WriteLine(count >= 1 && count <= 3);
