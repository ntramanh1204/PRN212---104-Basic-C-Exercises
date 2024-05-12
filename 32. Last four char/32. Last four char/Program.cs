Console.Write("Input a string: ");
string str = Console.ReadLine();
int length = str.Length;
if (length < 4)
{
    Console.WriteLine(str);
} else
{
    for (int i = 0; i < 4; i++)
    Console.Write(str.Substring(length - 4)); 
}