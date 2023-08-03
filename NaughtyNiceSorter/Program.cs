// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using NaughtyNiceSorter;

Console.WriteLine("Naughty & Nice Sorter");

// setting a variable to the location of santalist file 
var santasListLocation = Path.Combine(Directory.GetCurrentDirectory(), @"../../../SantaSpatanList.csv");

// we are usign a file operation to go through the file and assign just line to a variable in array 
var santalist = File.ReadAllLines(santasListLocation).Skip(1);
var niceSpatans = new List<NiceSpatan>();
var naughtySpartans = new List<NaughtySpartan>();


// Creating a list of presents 
var presents = new List<string>
{
    "chocolotae Frong",
    "Pony",
    "Playstation 5"

};


var piecesofcoal = new List<string>
{
    "Read your programming notes ",
            "Attend class early",
            "No Playstation 5",
            "No Christmass gift"

};
// we going iteracte or loop through this array and write it out all the information from this SantaSpatanList into the console
foreach (var line in santalist)
{
    var details = line.Split(',');
    if (bool.Parse(details[2]) && bool.Parse(details[3]) && bool.Parse(details[4]))

    {  
        NiceSpatan niceSpatan = new NiceSpatan(details[0], details[1]);
        niceSpatan.DecidedPresent();
        niceSpatans.Add(niceSpatan);
    }

    else
    {
        NaughtySpartan naughtySpartan = new NaughtySpartan(details[0], details[1], details[2]);
        naughtySpartan.DecidedPresent();
        naughtySpartans.Add(naughtySpartan);
    }

}
int naughtySpartansCount = naughtySpartans.Count();
Console.WriteLine("Naughty Spartans: " + naughtySpartansCount);

int niceSpatansCount = niceSpatans.Count();
Console.WriteLine("Nice Spartans: " + niceSpatansCount);

// variable which set where we want to store our nice SpartansList 

var niceListLocation = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\NiceList.csv");

// after we use a file operation to writealltext to our nicelist- which takes two argumnents
// the location(niceListLocaion) of where we want to write the text to / what we want to write in the
//in the text ("Name, Location, Present) as headers and used (\n) to go to the next line this helps us
// when we create the list that a new spartan is added to every role rather than to one line 

File.WriteAllText(niceListLocation, "Name,Location,Present\n");

// after we create a for loop, for each nicespartan within our nicespartanlist i want to store the details
// of the nicespartan within this string - which is going to be the (nicepartans Name, nicepartans Location,
// nicepartans Present)\n and a back slash N to goto the next line 

foreach (var niceSpatan in niceSpatans)  
{
    var detials = $"{niceSpatan.Name},{niceSpatan.Location},{niceSpatan.Present}\n";

    // after we use file operation to AppedALLTEXT that take two arguements 1.location of our nicelist 
    // niceListLocation and also 2.(string the details of our nicespartans) 

    File.AppendAllText(niceListLocation, detials);
}


var naughtyListLocation = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\NaughtyList.csv");

File.WriteAllText(naughtyListLocation, "Name,Location,Present\n");

foreach (var naughtySpartan in naughtySpartans)
{
    var detials = $"{naughtySpartan.Name},{naughtySpartan.Location},{naughtySpartan.Present}\n";

    // after we use file operation to AppedALLTEXT that take two arguements 1.location of our nicelist 
    // niceListLocation and also 2.(string the details of our nicespartans) 

    File.AppendAllText(naughtyListLocation, detials);
    

}
//NiceSpatan cathy = new NiceSpatan("Cathy French", "London", "Chocolate Frog");
//Console.WriteLine(cathy.ToString());