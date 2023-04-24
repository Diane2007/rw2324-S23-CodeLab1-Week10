using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Super-Class: MonoBehavior
//Class: Directory
public class Directory : MonoBehaviour
{
    public Text text; //variable for component that displays the text

    //NOTE: notice that this is a list of NYUPerson, but can still hold all subclasses. THAT'S POLYMORPHISM, BABY!
    public List<NYUPerson> nyuPeopleList; //list of people at nyu

    int recordNum = 0;

    // Start is called before the first frame update
    void Start()
    {
        nyuPeopleList = new List<NYUPerson>();

        //make a new NYUFaculty 
        //Class: NYUPerson; Object: MattParker
        NYUPerson mattParker = new NYUFaculty("Matt Parker", "mp612",
                                                999999.12f, false);

        NYUPerson diane = new NYUGrad("Diane Wang", "rw2324",
                                            3.917f, 34, 4);
        
        NYUPerson andy = new NYUAdmin("Alexander Hamilton", "ah0000",
                                        2000000f, "NYU President");
        
        nyuPeopleList.Add(mattParker); //add mattParker to the nyuPeopleList
        
        //We can add me to the list because NYUStudent IS AN NYUPerson
        nyuPeopleList.Add(diane);
        nyuPeopleList.Add(andy);
        
        UpdateRecord(); //update the text display to show the the info from the first person in the list
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){ //if space is pressed
            UpdateRecord(); //change the record to display the next person in the list
        }
    }

    void UpdateRecord(){
        //get the remainder
        NYUPerson person = nyuPeopleList[recordNum % nyuPeopleList.Count]; //grab the object a person in the list (use % to wrap around)

        //because NYUPerson has a ShowRecord() function,
        //NYUStudent also has it even though we haven't written it out in NYUStudent
        text.text = person.ShowRecord(); //display the info for this object

        recordNum++; //increase the recordNum so we show the next person next time through
    }
}
