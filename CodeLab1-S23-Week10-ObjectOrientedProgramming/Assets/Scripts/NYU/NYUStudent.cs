using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//WE JUST EXTENDED NYUPERSON!!! HOW COOL IS THAT!!

//Super-Class: NYUPerson
//Class: NYUStudent
public class NYUStudent : NYUPerson
{
    //these things are specific to NYUStudents, but not necessarily to NYUPerson
    public float gpa = 4.0f;
    public int credits = 0;
    
    //the thing above us is base
    public NYUStudent(string name, string netId, float gpa, int credits) : 
        base(name, netId)
        //You have to put base() in because we are extending from NYUPerson
        //base accesses the class above us (NYUPerson) and returns name and netId in that script
    {
        this.gpa = gpa;
        this.credits = credits;

        //I'm extending from NYUPerson (and there is a type in there)
        //so the script knows about type and we don't have to init any thing. HOW COOL!!!
        type = "NYU Student";
    }

    public override string ShowRecord()
    {
        //show our name, netId, and type
        return base.ShowRecord() + "GPA: " + gpa + "\nCredits: " + credits + "\n";
    }

}
