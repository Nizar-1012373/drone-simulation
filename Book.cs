using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//constructors
namespace Drone
{

  class Book
  {
    public string? title;
    public string? author;
    public int pages;

    // this is a constrcutor method
    public Book(string name){
      Console.WriteLine(name);
    }

  }
}