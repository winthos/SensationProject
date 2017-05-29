using UnityEngine;
using System.Collections;

public class DoorLogic : MonoBehaviour 
{
    private GameObject TimeGlobal;
    public GameObject WhereAreYou;
    public GameObject PreFabToMake;

    // Use this for initialization
    void Start () 
	{
        TimeGlobal = GameObject.Find("LevelGlobals");
    }
	
	// Update is called once per frame
	void Update () 
	{
        if (TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            return;
        }

        if (TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == false)
        {
            if(WhereAreYou.GetComponent<OrbLogicAttempt>().GoalReached == true)
            {
                GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
