
using System.Runtime.CompilerServices;

List<string> choices = ["Docka", "Bil", "Pistol", "Dinosaurie", "Slime"];

foreach (string choice in choices)
{
  Console.WriteLine(choice);
}

List<string> klasa = ["joan, kim, per, olaf, karin"];

List<int> numbers = [1, 2, 3, 4, 5];



List<string> cities = new();

string answer = "";
while (answer != "exit")
{
  Console.WriteLine("Write a city");
  answer = Console.ReadLine();
  if (answer != "exit")
  {
    cities.Add(answer);
  }
}
for (int k = 0; k < cities.Count; k++)
{
  
Console.WriteLine(cities[k]);
}
Console.ReadLine();