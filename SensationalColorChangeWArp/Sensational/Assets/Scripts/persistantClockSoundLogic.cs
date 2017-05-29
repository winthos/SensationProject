using UnityEngine;
using System.Collections;

public class persistantClockSoundLogic : MonoBehaviour 
{
    private bool IsTimeStopped;
    private bool dothisonce = false;

    // Use this for initialization
    void Start () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
    }
	
	// Update is called once per frame
	void Update () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        if (IsTimeStopped == true)
        {
            //turn on filter
            if(dothisonce == false)
            {
                AudioSource source = GetComponent<AudioSource>();
                source.Play();
                dothisonce = true;
            }


        }

        if (IsTimeStopped == false)
        {
            //turn off filter

            AudioSource source = GetComponent<AudioSource>();
            source.Pause();
            dothisonce = false;
        }
    }
}
