using UnityEngine;
using System.Collections;

public class LevelGlobals : MonoBehaviour 
{
    public bool TimeStopped = false;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (Input.GetMouseButtonDown(1) && TimeStopped == false)
        {
            TimeStopped = true;
        }
        else if(Input.GetMouseButtonDown(1) && TimeStopped == true)
        {
            TimeStopped = false;
        }
	}
}
