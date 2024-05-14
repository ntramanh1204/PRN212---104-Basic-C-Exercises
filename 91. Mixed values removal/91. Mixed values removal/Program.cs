// Initializing an array of objects with various types of values
object[] mixedArray = new object[6];
mixedArray[0] = 25;
mixedArray[1] = "Anna";
mixedArray[2] = false;
mixedArray[3] = System.DateTime.Now;
mixedArray[4] = -112;
mixedArray[5] = -34.67;

int[] new_nums = mixedArray.OfType<int>().ToArray();

for (int i = 0; i < new_nums.Length; i++)
{
    Console.Write(new_nums[i] + " ");
}