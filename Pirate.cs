using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//constructors
namespace Drone
{

  class Pirate
  {
    public string? name;
    public string? group;
    public int haki;

    // this is a constrcutor method (in python zou je vaak dan __init__ maken of __repr__)
    public Pirate(string aName,string aGroup,int aHakiLevel){
      name= aName;
      group = aGroup;
      haki = aHakiLevel;
    }

    public bool HasConquerorshaki(){
      if(haki >= 100){
        return true;
      }
      return false;
    }
  }
}