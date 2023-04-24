using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NYUAdmin : NYUStaff
{
    public string adminPosition;

    public NYUAdmin(string name, string netId, float salary, string adminPosition) : base(name, netId, salary)
    {
        this.adminPosition = adminPosition;

        type = "NYU Admin";
    }

    public override string ShowRecord()
    {
        return base.ShowRecord() + "Position: " + adminPosition + "\n";
    }
}
