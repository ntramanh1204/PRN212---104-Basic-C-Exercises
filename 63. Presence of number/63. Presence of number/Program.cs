int given_num = 2;
int[] a = { 1, 2, 3, 4, 5 };
foreach (int i in a)
{
    if (i == given_num)
    {
        Console.WriteLine(true);
        return;
    }
}
Console.WriteLine(false);