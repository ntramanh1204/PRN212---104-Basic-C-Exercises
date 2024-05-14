string[] arr = { "Padas", "Packed", "Pace", "Pacha" };
if (arr.Length == 0 || Array.IndexOf(arr, "") != -1)
{
    Console.WriteLine();
    return;
}

string result = arr[0];
int i = result.Length;

foreach (string word in arr)
{
    int j = 0;

    foreach (char c in word)
    {
        if (j >= i || result[j] != c)
            break;
        j += 1;
    }

    i = Math.Min(i, j);
}

Console.WriteLine(result.Substring(0, i));