using System;

string name =  "";
string favoriteProtein =  "";
string pr =  "";

Console.WriteLine("Vad heter du?");
name = Console.ReadLine();

Console.WriteLine("Vad är din favorit protein/supplement");
favoriteProtein = Console.ReadLine();

Console.WriteLine("Soft, vad är din pr?");
pr = Console.ReadLine();

Console.WriteLine($"Tja {name}, hörde att du bara maxar {pr}, om du ska vara så svag varför ens ta {favoriteProtein}");

Console.WriteLine("");
Console.WriteLine("Haft nog? ENTER för att ge upp");
Console.ReadLine();