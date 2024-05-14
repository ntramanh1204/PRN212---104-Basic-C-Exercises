Console.Write("Input a string: ");
string str = Console.ReadLine();
if (str.Length < 4)
{
    Console.WriteLine(str.ToUpper());
} else
{
    str = str.Substring(0, 4).ToLower() + str.Substring(4);
    Console.WriteLine(str);
}