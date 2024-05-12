int[] arr1 = { 1, 3, -5, 4 };
int[] arr2 = { 1, 4, -5, -2 };
int[] result = new int[arr1.Length];

for (int i = 0; i < result.Length; i++)
{
    result[i] = arr1[i] * arr2[i];
}

Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));
Console.WriteLine("Multiply corresponding elements of two arrays:");
Console.WriteLine("{0}", string.Join(" ", result));
