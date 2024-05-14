int[] nums = { 10, -11, 12, -13, 14, -18, 19, -20 };
Console.WriteLine("Positive: " + nums.Where(n => n > 0).Count());
Console.WriteLine("Negative: " + nums.Where(n => n < 0).Count());
