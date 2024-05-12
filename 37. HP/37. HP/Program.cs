string test = "PHP Tutorial";
Console.WriteLine($"Test Data: {test}");
if ( test.Substring( 1, 2 ).Equals("HP"))
{
    test = test.Substring(0, 1) + test.Substring(3);
}
Console.WriteLine(test);
