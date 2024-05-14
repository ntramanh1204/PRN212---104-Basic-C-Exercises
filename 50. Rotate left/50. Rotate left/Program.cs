int[] arr = { 1, 2, 8 };
int[] new_arr = new int[arr.Length];
for (int i = 0; i < arr.Length - 1; i++)
{
    new_arr[i] = arr[i + 1];
}
new_arr[arr.Length - 1] = arr[0];

Console.WriteLine("[{0}]", string.Join(", ", new_arr));