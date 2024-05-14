int[] arr = { 2, 4, 7, 8, 6 };
Console.WriteLine("Original array: [{0}]", string.Join(", ", arr));
Console.Write("Check if an array contains an odd number? ");
foreach (int i in arr)
{
    if (i % 2 != 0)
    {
        Console.WriteLine("True");
        break;
    }
}