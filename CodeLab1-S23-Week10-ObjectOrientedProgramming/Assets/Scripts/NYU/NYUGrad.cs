using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUGrad : NYUStudent
{
    //the unit is semester
    public int degreeDuration = 4;

    public NYUGrad(string name, string netId, float gpa, int credits, int degreeDuration) : 
        base(name, netId, gpa, credits)
    {
        this.degreeDuration = degreeDuration;

        type = "Grad Student";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "Degree duration: " + degreeDuration + " semesters\n";
    }
}
