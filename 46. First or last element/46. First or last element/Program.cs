int[] nums = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 9 };
Console.Write("Input an integer: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(num == nums[0] || num == nums[nums.Length - 1]);