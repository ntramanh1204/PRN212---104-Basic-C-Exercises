public class Example
{
    public static int Sum(int[][] matrix)
    {
        int sum = 0; 
        for (int i = 0; i < matrix[0].Length; i++)
        {
            for (int j = 0; j < matrix.Length && matrix[j][i] > 0; j++)
            {
                sum += matrix[j][i];
            }
        }
        return sum;
    }
    public static void Main()
    {
        int[][] matrix = {
            new int[]{0, 2, 3, 2},
            new int[]{0, 6, 0, 1},
            new int[]{4, 0, 3, 0}
        };
        Console.WriteLine(Sum(matrix));
    }
}