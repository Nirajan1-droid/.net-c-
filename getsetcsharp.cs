using System;

namespace MyApplication
{
  class Person
  {
    private string name;  // field
    public string Name    // property
    {
      get { return name; }
      set { name = value; }
    }  
    //myObj.Name = "Liam"; Name is declared on the another class.
    //value is the carried value from the another class.
    //that then is set to the private project of the class
  }
}
