using MyFirstProgram;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;
using static System.Formats.Asn1.AsnWriter;

// credit to @discord memeber pablocappuccino
// this is project is a following to thecCsharpAcadmey.com tutorials

var menu = new Menu();
var date = DateTime.UtcNow;
var games = new List<string>();
string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type your name");
    var name = Console.ReadLine();
    return name;
}





