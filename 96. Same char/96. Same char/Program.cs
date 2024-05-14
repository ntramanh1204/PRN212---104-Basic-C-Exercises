string text = "aaa";
if (text.Length > 1)
{
    var b = text[0]; 
    for (int i = 1; i < text.Length; i++)
    {
        var c = text[i];if (c != b)
        {
            Console.WriteLine(false);
            return;
        }
    }
}
Console.WriteLine(true);