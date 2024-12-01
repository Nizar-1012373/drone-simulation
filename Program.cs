using System;
using System.Drawing;
using System.Security.Cryptography;


namespace Drone
{
    // classes and objects
    class Hello
    {
        static void Main(string[] args)
        {   
            Book book1 = new Book("Nizar");
            book1.title = "drie fundamenten";
            book1.author = "Mohamed ibn abdulwahab";
            book1.pages = 30;

            Book book2 = new Book("Mohamed");
            book2.title = "kitab at tawheed";
            book2.author = "ibn Taymiya";
            book2.pages = 192;

            Console.WriteLine(book2.title);
        }
        
    
    
    
    }
}