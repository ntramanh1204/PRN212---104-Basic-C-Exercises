using System.Text.RegularExpressions;

string text = "Python";
Console.WriteLine(new Regex(@"[aeiouAEIOU]").Replace(text, ""));