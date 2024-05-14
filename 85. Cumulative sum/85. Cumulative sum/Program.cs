double[] nums = { 1, 3, 4, 5, 6, 7 };
for (int i = 1; i < nums.Length; i++)
{
    nums[i] = nums[i] + nums[i - 1];
}
Console.WriteLine("{0}", string.Join(", ", nums));
