int[] arr = { 2, 4, 2, 6, 9, 3 };
int max = 0;
(int, int) pair = (0, 0);
for (int i = 0; i < arr.Length - 1; i++)
{
    if (arr[i] * arr[i + 1] > max)
    {
        max = arr[i] * arr[i + 1];
        pair = (arr[i], arr[i + 1]);
    }
}
Console.WriteLine(pair);