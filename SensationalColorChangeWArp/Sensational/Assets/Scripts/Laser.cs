using UnityEngine;
using System.Collections;

public class Laser : MonoBehaviour 
{
    private LineRenderer line;
    private bool IsTimeStopped;

    public Material FirstColor;
    public Material SecondColor;
    // Use this for initialization
    void Start () 
	{
        line = GetComponent<LineRenderer>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;

        if(IsTimeStopped == true)
        {
            gameObject.GetComponent<LineRenderer>().material = SecondColor; 
        }
        if(IsTimeStopped == false)
        {

            gameObject.GetComponent<LineRenderer>().material = FirstColor;
        }

        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if(hit.collider && hit.collider.gameObject.name != "StandCollider" )
            {
                //print(hit.collider);
                if(IsTimeStopped == false)
                line.SetPosition(1, new Vector3(0, 0, hit.distance));

               // print("distance is " + hit.distance);
                //print("distance is " + Vector3.Distance(transform.position, hit.point));
            }
        }

        else
        {
            if(IsTimeStopped == false)
            {
                line.SetPosition(1, new Vector3(0, 9, 5000));
            }

        }
	}
}
