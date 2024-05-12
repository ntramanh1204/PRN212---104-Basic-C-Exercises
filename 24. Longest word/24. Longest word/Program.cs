string str = "Write a C# Sharp Program to display the following pattern using the alphabet.";
string[] words = str.Split(' ');
int maxlength = 0;
string maxword = "";
foreach (string word in words)
{
    if (word.Length > maxlength)
    {
        maxlength = word.Length;
        maxword = word;
    }
}
Console.WriteLine(maxword);