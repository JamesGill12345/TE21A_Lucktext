string name;
string land;
string djur;

Console.WriteLine ("vad heter du");
name = Console.ReadLine();

Console.WriteLine ("vilket är ditt favoritland");
land = Console.ReadLine();

Console.WriteLine ("vad är ditt favoritdjur");
djur = Console.ReadLine();


Console.WriteLine($"hej {name}");
Console.WriteLine($"du bor i {land}");
Console.WriteLine($"med en {djur}");


Console.ReadLine();