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
            Book book1 = new Book("drie fundamenten","Mohamed ibn abdulwahab",30);
            

            Book book2 = new Book("kitab at tawheed","ibn Taymiya",192);
          

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);
        }
        
    
    
    
    }
}