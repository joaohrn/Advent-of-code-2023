using System.Runtime.CompilerServices;

StreamReader sr = new StreamReader("./../Inputs.txt");
var line = sr.ReadLine();
IEnumerable<int> numbers = [];
while (line != null)
{
    string num = "";
    foreach (char c in line)
    {
        if ("1234567890".Contains(c))
        {
            num += c;

        }
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
    sum += num;
}
Console.WriteLine("" + sum);