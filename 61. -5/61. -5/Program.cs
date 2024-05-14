class Program
{
 
    public static int[] Sort(int[] arr)
    {
        int[] num = arr.Where(x => x != -5).OrderBy(x => x).ToArray();
        int count = 0;
        return arr.Select(x => x >= 0 ? num[count++] : -5).ToArray();
    }

    public static void Main()
    {
        int[] x = Sort(new int[] { -5, 236, 120, 70, -5, -5, 698, 280 });
        foreach (var item in x)
        {
            Console.WriteLine(item.ToString());
        }
    }
}
