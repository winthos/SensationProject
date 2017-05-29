using UnityEngine;
using System.Collections;

public class ClockLogic : MonoBehaviour 
{
    private GameObject TimeGlobal;
    // Use this for initialization
    private float TotalTimeSoFar;

    public GameObject LastDoor;

    void Start () 
	{
        TimeGlobal = GameObject.Find("LevelGlobals");
        LastDoor = GameObject.Find("LastDoor");
    }
	
	// Update is called once per frame
	void Update () 
	{
        if (LastDoor == null)
        {
            return;
        }

        if (TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            return;
        }

        if (TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == false)
        {
            TotalTimeSoFar += Time.deltaTime;

            gameObject.GetComponent<TextMesh>().text = "TIME TAKEN: " + TotalTimeSoFar.ToString("F2");
        }

    }
}
