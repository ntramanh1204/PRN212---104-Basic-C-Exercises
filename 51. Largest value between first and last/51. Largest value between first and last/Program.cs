int[] arr1 = { 1, 2, 5, 7, 8 };
Console.WriteLine("Array1: [{0}]", string.Join(", ", arr1));
int largest;
if (arr1[0] > arr1[arr1.Length - 1]) largest = arr1[0];
else largest = arr1[arr1.Length - 1];
Console.WriteLine("Highest value between first and last values of the said array: " + largest);