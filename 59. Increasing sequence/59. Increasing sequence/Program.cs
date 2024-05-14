class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 3, 5, 6, 9 };
        Console.WriteLine(IsIncreasing(arr));
    }

    static bool IsIncreasing(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                return false;
            }
        }
        return true;
    }
}


