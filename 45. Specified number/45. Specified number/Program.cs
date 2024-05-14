int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
Console.Write("Input an integer: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Number of 5 present in the said array: ");
Console.WriteLine(nums.Count(n => n == x));