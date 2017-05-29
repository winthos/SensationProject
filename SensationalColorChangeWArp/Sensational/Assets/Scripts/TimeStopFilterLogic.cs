using UnityEngine;
using System.Collections;

public class TimeStopFilterLogic : MonoBehaviour 
{
    //throw this script on the filter
    private bool TimeState;

    public float scale = 0.5f;
    public float minScale = 0.13f;
    public float maxScale = 30f;
    public float scaleSpeed = 100f;

    // Use this for initialization
    void Start () 
	{
        TimeState = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        
    }
	
	// Update is called once per frame
	void Update () 
	{
        TimeState = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        //time is normal
        if (TimeState == false)
        {
            
            scale -= scaleSpeed * Time.deltaTime;
            if(scale <minScale)
            {
                scale = minScale;
            }
            transform.localScale = new Vector3(scale, scale, scale);
        }

        //time stopped
        if (TimeState == true)
        {
            scale += scaleSpeed * Time.deltaTime;
            if(scale > maxScale)
            {
                scale = maxScale;
            }

            transform.localScale = new Vector3(scale, scale, scale);
        }
    }
}
