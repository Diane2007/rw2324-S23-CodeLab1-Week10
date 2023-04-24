using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//this is the base class for anyone associated w/ NYU

//We don't have monobehavior!
//It is just a container of information. We can't attach it to a gameObject as a component.
//But other components can access the information.

//Super-Class: nothing
//Class: NYUPerson
public class NYUPerson
{
    public string name;
    public string netId;
    public string type;

    public NYUPerson()
    {        
        //make default constructor
        name = "Insert name";
        netId = "aa0000";
        type = "NYU Person";
        
    }

    //this is the base constructor
    public NYUPerson(string name, string netId)
    {
        //no void? no int?? no bool???
        //This is a constructor!!
        //a way to create a new object of that type, and give it some information when we start
        //It returns an instance of that class, or an object of that class
        
        //this: The instance I'm creating gets the name passed to it
        //      The instance I'm creating gets the netId value passed to its netId box
        this.name = name;
        this.netId = netId;
        type = "NYU Person";
    }

    //this is a virtual function, that can be overridden
    public virtual string ShowRecord()
    {
        //virtual can be overloaded by any of the subclasses
        //because NYUStudent has more information (gpa and credits) than NYUPerson
        //so we need virtual
        //check NYUStudent's override function
        return
            "Name: " + name + "\n" +
            "Type: " + type + "\n" +
            "NetId: " + netId + "\n";
    }
}
