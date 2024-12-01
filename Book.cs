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

    // this is a constrcutor method (in python zou je vaak dan __init__ maken of __repr__)
    public Book(string aTitle,string aAuthor,int aPages){
      title = aTitle;
      author = aAuthor;
      pages = aPages;
    }

  }
}