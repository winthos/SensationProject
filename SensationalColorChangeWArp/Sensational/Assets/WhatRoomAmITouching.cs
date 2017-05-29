using UnityEngine;
using System.Collections;

public class WhatRoomAmITouching : MonoBehaviour 
{
    //this is on the player
    public GameObject LevelGlobals;

    public bool ImInRoom1 = false;
    public bool ImInRoom2 = false;
    public bool ImInRoom3 = false;
    public bool ImInRoom4 = false;
    public bool ImInRoom5 = false;
    public bool ImInRoom6 = false;
    public bool ImInRoom7 = false;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	 
	}

    void OnTriggerExit(Collider other)
    {
        if(other.name == "Room1Collider")
        {
            LevelGlobals.GetComponent<Room1Data>().StartUpdatingTime = false;
            ImInRoom1 = false;
        }

        if (other.name == "Room2Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room2Data>().StartUpdatingTime = false;
            ImInRoom2 = false;
        }

        if (other.name == "Room3Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room3Data>().StartUpdatingTime = false;
            ImInRoom3 = false;
        }

        if (other.name == "Room4Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room4Data>().StartUpdatingTime = false;
            ImInRoom4 = false;
        }

        if (other.name == "Room5Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room5Data>().StartUpdatingTime = false;
            ImInRoom5 = false;
        }

        if (other.name == "Room6Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room6Data>().StartUpdatingTime = false;
            ImInRoom6 = false;
        }

        if (other.name == "Room7Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room7Data>().StartUpdatingTime = false;
            ImInRoom7 = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Room1Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room1Data>().StartUpdatingTime = true;
            ImInRoom1 = true;
            
        }

        if (other.name == "Room2Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room2Data>().StartUpdatingTime = true;
            ImInRoom2 = true;
        }

        if (other.name == "Room3Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room3Data>().StartUpdatingTime = true;
            ImInRoom3 = true;
        }

        if (other.name == "Room4Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room4Data>().StartUpdatingTime = true;
            ImInRoom4 = true;
        }

        if (other.name == "Room5Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room5Data>().StartUpdatingTime = true;
            ImInRoom5 = true;
        }

        if (other.name == "Room6Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room6Data>().StartUpdatingTime = true;
            ImInRoom6 = true;
        }

        if (other.name == "Room7Collider")
        {
            //print("yes yes yes");
            LevelGlobals.GetComponent<Room7Data>().StartUpdatingTime = true;
            ImInRoom7 = true;
        }
    }
}
