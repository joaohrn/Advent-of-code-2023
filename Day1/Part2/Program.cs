StreamReader sr = new StreamReader("./../Inputs.txt");
var line = sr.ReadLine();
IEnumerable<int> numbers = [];
while (line != null)
{
    line = ConvertToDigits(line);

    string num = "";
    foreach (char c in line)
    {
        if ("1234567890".Contains(c))
            num += c;
    }

    num = num[0].ToString() + num[^1];
    int lineNum = int.Parse(num);
    numbers = numbers.Append(lineNum);
    line = sr.ReadLine();
}
sr.Close();
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
string test = "two2three5adassix";
Console.WriteLine(ConvertToDigits(test));