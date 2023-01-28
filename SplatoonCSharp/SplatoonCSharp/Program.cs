// See https://aka.ms/new-console-template for more information
using SplatoonCSharp;

Console.WriteLine("Welcome to Splatoon 4!");
Console.WriteLine("Enter Player 1's name:");
Player player1 = new SplatoonCSharp.Player();
string player1Name = Console.ReadLine();
player1.Name = player1Name;
player1.setInkColor();

Console.WriteLine("Enter Player 2's name:");
Player player2 = new SplatoonCSharp.Player();
string player2Name = Console.ReadLine();
player2.Name = player2Name;

while (player2.Color == player1.Color)
{
    player2.setInkColor();  
}
List<Player> playerList = new List<SplatoonCSharp.Player>();
playerList.Add(player1);    
playerList.Add(player2);

foreach (Player p in playerList)
{
    Console.WriteLine(p.Name + " is using ink color:" + p.Color);
}
