using UnityEngine;
using System.Collections;

public class TimeStopSoundLogic : MonoBehaviour 
{
    private bool TimeState;
    bool dothisonce = false;

    // Use this for initialization
    void Start () 
	{
        TimeState = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
    }
	
	// Update is called once per frame
	void Update () 
	{
        TimeState = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        //print(TimeState);
        if (TimeState == false && dothisonce == false)
        {
           // print("stop time stop sound" );
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
            dothisonce = true;
        }

        if (TimeState == true && dothisonce == true)
        {
            //print("start time stop sound");
            //return;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
            dothisonce = false;
        }

    }
}
