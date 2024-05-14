int n = 12;
int ones = Convert.ToString(n, 2).Count(c => c == '1');
int zeros = Convert.ToString(n, 2).Count(c => c == '0');
Console.WriteLine(ones);
Console.WriteLine(zeros);