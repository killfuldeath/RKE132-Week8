string folderpath = @"C:\Users\henri\Documents\data";
string herofile = "heroes.txt";
string villainfile = "villains.txt";


string[] heroes = File.ReadAllLines(Path.Combine(folderpath, herofile));
string[] villains = File.ReadAllLines(Path.Combine(folderpath, villainfile));


//string[] heroes = { "Harry Potter", "Luke Skywalker", "Lara Croft", "Bilbo Baggins", "Scooby-Doo" };
//string[] villains = { "Voldemort", "Darth Vader", "Dracula", "Joker", "Sauron" };

string[] weapons = { "brick", "noose" };

string weapon = dotherandomsmh(weapons);
string weapon2 = dotherandomsmh(weapons);



string hero = dotherandomsmh(heroes);
string villain = dotherandomsmh(villains);

int herohp = charhp(hero);
int villainhp = charhp(villain);
int herostrikestr = herohp;
int villainstrikestr = villainhp;

Console.WriteLine($"Today {villain} ({villainhp}) does very bad things with a {weapon}!"); //aus jutt, kes kordab ennast kaks korda et teha ühte asja? kaotad oma töö niimoodi sihukeses alas
Console.WriteLine($"Today {hero} ({herohp}) does super nice things with a {weapon2}!");

while(herohp > 0 && villainhp > 0)
{
    herohp = herohp - hit(villain, villainstrikestr);
    villainhp = villainhp - hit(hero, herostrikestr);
}

Console.WriteLine($"{hero} HP: {herohp} ");
Console.WriteLine($"{villain} HP: {villainhp}");


if (herohp > 0)
{
    Console.WriteLine($"{hero} saved the day!");
}
else if (villainhp > 0)
{
   Console.WriteLine($"{villain} wins!");
}
else
{
    Console.WriteLine("Draw!");
}

static string dotherandomsmh(string[] funnyArray)
{
    Random rnd = new Random();

    int randomindex = rnd.Next(0, funnyArray.Length);

    string fun = funnyArray[randomindex];
    return fun;
}

static int charhp(string charname)
{
    if (charname.Length < 10)
    {
        return 10;
    }
    else
    {
        return charname.Length;
    }
}


static int hit( string charname, int charhp)
{
    Random rnd = new Random();
    int strike = rnd.Next(0, charhp);

    if (strike == 0)
    {
        Console.WriteLine($"{charname} missed, how embarrasing.");
    }
    else if (strike == charhp - 1)
    {
        Console.WriteLine($"{charname} GOT A CRITICAL HIT!");
    }
    else
    {
        Console.WriteLine($"{charname} hit {strike}");
    }

    return strike;
}