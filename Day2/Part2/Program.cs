using System.Xml.XPath;

StreamReader sr = new StreamReader("./../Inputs.txt");
var line = sr.ReadLine();
IEnumerable<int> Powers = [];
while (line != null)
{
    int GameID = int.Parse(line.Split(':')[0].Split(' ')[1]);
    string[] Results = string.Join(',', line.Split(':')[1].Split(';')).Split(',');
    int redMin = 0;
    int blueMin = 0;
    int greenMin = 0;
    foreach (string result in Results)
    {
        string[] game = result.Trim().Split(" ");
        if (game[1] == "red" && int.Parse(game[0]) > redMin)
        {
            redMin = int.Parse(game[0]);
        }
        else if (game[1] == "green" && int.Parse(game[0]) > greenMin)
        {
            greenMin = int.Parse(game[0]);
        }
        else if (game[1] == "blue" && int.Parse(game[0]) > blueMin)
        {
            blueMin = int.Parse(game[0]);
        }
    }
    Powers = Powers.Append(redMin * greenMin * blueMin);
    line = sr.ReadLine();
}

sr.Close();

int sum = 0;
foreach (int Power in Powers)
{
    sum += Power;
}

Console.WriteLine(sum);