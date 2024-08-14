
var text = "two1nine,eightwothree,abcone2threexyz,xtwone3four,4nineeightseven2,zoneight234,7pqrstsixteen";
string[] lines = text.Split(",");
IEnumerable<int> numbers = [];
for (int i = 0; i < lines.Length; i++)
{
    lines[i] = ConvertToDigits(lines[i]);

    string num = "";
    foreach (char c in lines[i])
    {
        if ("1234567890".Contains(c))
            num += c;
    }

    num = num[0].ToString() + num[^1];
    int lineNum = int.Parse(num);
    numbers = numbers.Append(lineNum);
}
int sum = 0;
foreach (int num in numbers)
{
    Console.Write(num.ToString() + ", ");
    sum += num;
}
Console.WriteLine("" + sum);

string ConvertToDigits(string str)
{
    str = str.Replace("one", "o1e");
    str = str.Replace("two", "t2o");
    str = str.Replace("three", "t3e");
    str = str.Replace("four", "f4r");
    str = str.Replace("five", "f5e");
    str = str.Replace("six", "s6x");
    str = str.Replace("seven", "s7n");
    str = str.Replace("eight", "e8t");
    str = str.Replace("nine", "n9e");
    return str;
}