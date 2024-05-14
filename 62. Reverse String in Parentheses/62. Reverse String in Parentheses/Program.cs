string str = "a(bc)de";
int open = str.IndexOf('(');
int close  = str.IndexOf(")");
str =  str.Substring(0, open) + new string(str.Substring(open + 1, close - open - 1).Reverse().ToArray()) + str.Substring(close + 1);
Console.WriteLine(str);