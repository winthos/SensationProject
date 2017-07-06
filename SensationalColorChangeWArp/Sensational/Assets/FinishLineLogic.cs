using UnityEngine;
using System.Collections;

public class FinishLineLogic : MonoBehaviour 
{
    public bool test = false;
    public GameObject DataHolder = null;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    
	}

    void OnTriggerEnter (Collider col)
    {
        if(col.name == "FPSController" && test == false)
        {
            //make sure we only do this once
            test = true;

            DataHolder.GetComponent<DataNStuff>().SaveTheThing();

        }
    }
}
