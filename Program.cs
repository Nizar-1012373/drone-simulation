using System;
using System.Drawing;
using System.Security.Cryptography;


namespace Drone
{
    // classes and objects with constructors
    class Hello
    {
        static void Main(string[] args)
        {   
            Pirate pirate1 = new Pirate("Donquixote Doflamingo", "Donquixote pirates",110);
            Pirate pirate2 = new Pirate("Red hair Shanks", "Red hair pirates",200);
            Pirate pirate3 = new Pirate("Franky", "Straw hat pirates",50);

            Console.WriteLine("the pirate "+pirate1.name+" of the "+pirate1.group+" has Conqures haki "+pirate1.HasConquerorshaki());
            Console.WriteLine("the pirate "+pirate2.name+" of the "+pirate2.group+" has Conqures haki "+pirate2.HasConquerorshaki());
            Console.WriteLine("the pirate "+pirate3.name+" of the "+pirate3.group+" has no Conqures haki "+pirate3.HasConquerorshaki());

        }
        
    
    
    
    }
}