using UnityEngine;
using System.Collections;

public class TimeLenseLogic : MonoBehaviour 
{
    private GameObject LevelGlobals;

    private float count = 0f;
    private float speed = 1f;
    private Vector3 InitialScale;
    
	// Use this for initialization
	void Start () 
	{
        LevelGlobals = GameObject.Find("LevelGlobals");
        InitialScale = transform.localScale;
        transform.localScale = new Vector3(0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () 
	{
        //while time is stopped
	    if(LevelGlobals.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            if (count >= speed)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                return;
            }

            transform.localScale = Vector3.Lerp(Vector3.zero, InitialScale, count / speed);
            count += Time.deltaTime;
        }

        if (LevelGlobals.GetComponent<LevelGlobals>().TimeStopped == false)
        {

            gameObject.GetComponent<MeshRenderer>().enabled = true;
            transform.localScale = Vector3.zero;
            count = 0f;
        }

    }
}
