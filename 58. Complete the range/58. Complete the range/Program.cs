int[] arr = { 1, 3, 4, 7, 9 };
int count = 0;
for (int i = arr[0]; i <= arr[arr.Length - 1]; i++)
{
	if (!arr.Contains(i))
	{
		count++;
	}
}
Console.WriteLine(count);