int num = 86;

int firstDigit = num / 10;
int secondDigit = num % 10;

int swappedNumber = secondDigit * 10 + firstDigit;
Console.WriteLine(num > swappedNumber);