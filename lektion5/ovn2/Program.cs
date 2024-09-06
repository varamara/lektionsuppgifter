using System.Text;
List<int> numbers = [1, 6, 3, 5, 2, 1, 1, 4, 5, 3, 5, 5];
Dictionary<int, int> dictionary = [];
int counter = 0;
while (counter < numbers.Count)
{
    int currentVal = numbers[counter];
    if (!dictionary.TryGetValue(currentVal, out int value))
        dictionary.Add(currentVal, 1);
    else
        dictionary[numbers[counter]] = ++value;

    counter++;
}
printTable(dictionary);
static void printTable(Dictionary<int, int> dict)
{
    StringBuilder sb = new();
    sb.AppendLine($"Val:Frq");
    foreach (var x in dict.OrderBy(x => x.Key))
    {
        sb.AppendLine($"\u0020{x.Key} : {x.Value}");
    }
    Console.WriteLine(sb);
}