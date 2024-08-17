using System.Xml.XPath;

StreamReader sr = new StreamReader("./../Inputs.txt");
var line = sr.ReadLine();
IEnumerable<int> AllGames = [];
IEnumerable<int> BadGames = [];
while (line != null)
{
    int GameID = int.Parse(line.Split(':')[0].Split(' ')[1]);
    AllGames = AllGames.Append(GameID);
    string[] Results = string.Join(',', line.Split(':')[1].Split(';')).Split(',');
    foreach (string result in Results)
    {
        string[] game = result.Trim().Split(' ');
        if (CheckGameIsBad(game))
        {
            BadGames = BadGames.Append(GameID);
            break;
        }
    }
    line = sr.ReadLine();
}

sr.Close();
Console.WriteLine(string.Join(',', BadGames));

int sum = 0;
foreach (int game in AllGames)
{
    if (!BadGames.Contains(game))
        sum += game;
}


Console.WriteLine(sum);

bool CheckGameIsBad(string[] game)
{
    if (game[1] == "red")
    {
        return int.Parse(game[0]) > 12;
    }
    else if (game[1] == "green")
    {
        return int.Parse(game[0]) > 13;
    }
    else
    {
        return int.Parse(game[0]) > 14;
    }
}