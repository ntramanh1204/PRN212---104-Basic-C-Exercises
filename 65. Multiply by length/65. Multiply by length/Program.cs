int[] array = { 1, 2, 3, 4, 5 };
for (int i = 0; i < array.Length; i++)
{
    array[i] *= array.Length;
}
Console.WriteLine("{{{0}}}", string.Join(", ", array));