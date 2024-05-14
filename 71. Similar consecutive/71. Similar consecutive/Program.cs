string original = "Phpp";
for (int i = 0; i < original.Length - 1; i++)
{
    if (original[i] == original[i + 1])
    {
        Console.WriteLine(true);
        return;
    }
}
Console.WriteLine(false);