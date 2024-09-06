// List<string> words = ["Cykel", "Flyg", "Bil", "Färja", "Tåg", "Båt"];
// string temp;
// int counter = 0;
// while (counter < words.Count)
// {
// for (int j = 0; j < words.Count - 1; j++)
// {
// // compareTo returnerar ett tal större än, mindre än eller exakt 0
// // beroende på i det här fallet bokstavsordning
// // Så här kollar vi om nästa ord i listan (words[j + 1]) kommer före
// //ordet vi är på (words[j])
// // I så fall blir jämförelsen sann
// if (words[j].CompareTo(words[j + 1]) > 0)
// {
// temp = words[j + 1];
// words[j + 1] = words[j];
// words[j] = temp;
// }
// }
// counter++;
// }
// Console.WriteLine(string.Join(", ", words));
