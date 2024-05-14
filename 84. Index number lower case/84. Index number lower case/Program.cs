string str = "Hello";

for (int i = 0; i < str.Length; i++)
{
    if (char.IsLower(str[i]))
    {
        Console.Write(i + " ");
    }
}
