object[] arr = new object[5];
arr[0] = 25;
arr[1] = "Anna";
arr[2] = false;
arr[3] = DateTime.Now;
arr[4] = 112.22;

Console.WriteLine("Printing original array elements and their types:");
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine("Value-> " + arr[i] + " :: Type-> " + arr[i].GetType());
}

// Calling the test method to convert the array of objects to an array of strings
string[] new_nums = Array.ConvertAll(arr, x => x.ToString());

// Displaying the converted array elements and their types
Console.WriteLine("\nPrinting array elements and their types after conversion:");
for (int i = 0; i < new_nums.Length; i++)
{
    Console.WriteLine("Value-> " + new_nums[i] + " :: Type-> " + new_nums[i].GetType());
}