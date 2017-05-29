using UnityEngine;
using System.Collections;

public class ForwardAndBack : MonoBehaviour 
{

    public GameObject position1;
    public GameObject position2;

    public float speed;


    private bool IsTimeStopped;

	// Use this for initialization
	void Start () 
	{
       // print("hello?");
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
    }
	
	// Update is called once per frame
	void Update () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;

        if(IsTimeStopped == true)
        {
           // print("stop");
            return;
        }

        if(IsTimeStopped == false)
        {
           // print("ishouldbemoving");
            transform.position = Vector3.Lerp(position1.GetComponent<Transform>().position, position2.GetComponent<Transform>().position, Mathf.PingPong(Time.time * speed, 1.0f));

        }
    }
}
