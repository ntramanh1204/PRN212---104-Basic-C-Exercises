Console.Write("Input a string: ");
string str = Console.ReadLine();
char[] chars = str.ToCharArray();
for (int i = 0; i < chars.Length; i += 2)
{
    Console.Write(chars[i]);
}