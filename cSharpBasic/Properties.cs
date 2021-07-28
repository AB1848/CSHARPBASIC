using System;

internal class Person1
{
    public byte age;
    private int grade;
    public string name;
    public string address;
    private DateTime dateOfBirth;
    
    //getter setter
    public byte Age
    {
        get{ return age; }
        set
        {
            if(value> 30 && value < 40)
            {
               age=value;
            }
        }
    }
    // auto implemented properties 

    public string Address{ get; set;}

    //read only properties//shorcut to create property is by writing prop 
    public string Name { get;}
}    



