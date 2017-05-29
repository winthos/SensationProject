using UnityEngine;
using System.Collections;

public class TimeStartsSoundLogic : MonoBehaviour
{
    private bool TimeState;
    bool dothisonce = false;

    bool IPlayedTheFirstTime = false;

   // bool TimeWasStopped = false;

    // Use this for initialization
    void Start()
    {
        TimeState = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        //print(TimeState);


    }
    void Update()
    {
        if (TimeState == true && dothisonce == true)
        {
            //print("start time stop sound");
            //return;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Stop();
            dothisonce = false;
            IPlayedTheFirstTime = true;
        }

        if (IPlayedTheFirstTime == false)
        {
            dothisonce = true;
            if(dothisonce == false)
            return;
        }

        TimeState = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        //print(TimeState);
        if (TimeState == false && dothisonce == false)
        {

            // print("stop time stop sound" );

            if(IPlayedTheFirstTime == true)
            {
                AudioSource audio = GetComponent<AudioSource>();
                audio.Play();
                dothisonce = true;
            }

        }

    }
}
