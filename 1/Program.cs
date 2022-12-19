string[] lines = File.ReadAllLines("input.txt");

var elves = new List<int>();

elves.Add(0);
int elfCount = 0;

foreach (var line in lines)
{
    if (String.IsNullOrWhiteSpace(line))
    {
        elves.Add(0);
        elfCount++;
    }
    else
    {
        elves[elfCount] += int.Parse(line.Trim());
    }
}

var sortedElves = elves.OrderByDescending(x => x).ToList();

int topThree = sortedElves[0] + sortedElves[1] + sortedElves[2];

Console.WriteLine($"Top One: {sortedElves[0]}");
Console.WriteLine($"Top Three: {topThree}");