int[] arr1 = { 1, 2, 5 };
Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
int[] arr2 = { 0, 3, 8 };
Console.WriteLine("Array2: [{0}]", string.Join(", ", arr2));
int[] arr3 = { -1, 0, 2 };
Console.WriteLine("Array3: [{0}]", string.Join(", ", arr3));
int[] new_arr = { arr1[1], arr2[1], arr3[1] };
Console.WriteLine("New array: [{0}]", string.Join(", ", new_arr));