using UnityEngine;
using System.Collections;

public class FollowLine : MonoBehaviour 
{
    //moving line thing yaaaaay
    private LineRenderer lineRenderer;

    public Transform target;

    public Transform Point1;
    public Transform Point2;
   // public Transform Point3;
    //public Transform Point4;

    private float distance_P1_P2;
    //private float distance_P2_P3;
   // private float distance_P3_P4;

    private bool P1_P2_ReadyToDraw = false;
    private bool ReadyToReset = false;
   // private bool P2_P3_ReadyToDraw = false;
    //private bool P3_P4_ReadyToDraw = false;

    private float timer;

    public float MovementInterval = 10f;
    public float TimeBetweenMovement = 2.0f;

    public float TimeBeforeReset = 10f;
    private float TimeBeforeResetTimer;

    private int counter = 0;

    public float DelayTime = 5f;
    private float DelayTimeCounter;

    private bool active = false;

    private GameObject LevelGLobal;

    public Material FirstColor;
    public Material SecondColor;

    public float MoveSpeed = 5f;
    // Use this for initialization
    void Start () 
	{
        distance_P1_P2 = Vector3.Distance(Point1.position, Point2.position);
        //print("segment 1 is " + distance_P1_P2);
        // distance_P2_P3 = Vector3.Distance(Point2.position, Point3.position);
        //  print("segment 2 is " + distance_P2_P3);
        // distance_P3_P4 = Vector3.Distance(Point3.position, Point4.position);
        //  print("segment 3 is " + distance_P3_P4);
        LevelGLobal = GameObject.Find("LevelGlobals");


        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetWidth(0.3f, 0.3f);
        //set in initial position
        lineRenderer.SetPosition(0, Point1.position);
        lineRenderer.SetPosition(1, Point1.position);
       // lineRenderer.SetPosition(2, Point1.position);
        //lineRenderer.SetPosition(3, Point1.position);

        //move orb to first point
        target.position = Point1.position;

        P1_P2_ReadyToDraw = true;


    }

    // Update is called once per frame
    void Update()
    {
        if(LevelGLobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            gameObject.GetComponent<LineRenderer>().material = SecondColor;
        }
        else
        {
            gameObject.GetComponent<LineRenderer>().material = FirstColor;
        }
        /*
        //if time is stopped chill out
        if(LevelGLobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            return;
        }

        DelayTimeCounter += Time.deltaTime;
        if (DelayTimeCounter >= DelayTime)
        {
            active = true;
        }

        if (active == false)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (P1_P2_ReadyToDraw == true)
        {
            //timer -= Time.deltaTime;
            if (timer <= 0.0)
            {
                //print("drawing line count: " + counter);
                counter += 1;
                target.position = Vector3.MoveTowards(target.position, Point2.position, distance_P1_P2 / MovementInterval);
                lineRenderer.SetPosition(1, target.position);
                // lineRenderer.SetPosition(2, target.position);
                //  lineRenderer.SetPosition(3, target.position);
                timer = TimeBetweenMovement;
                if (counter >= MovementInterval)
                {
                    counter = 0;
                    P1_P2_ReadyToDraw = false;
                    ReadyToReset = true;
                    //P2_P3_ReadyToDraw = true;
                }
            }
        }

        if (ReadyToReset == true && P1_P2_ReadyToDraw == false)
        {
            //print("time for a reset: " + TimeBeforeResetTimer);
            TimeBeforeResetTimer += Time.deltaTime;
            if(TimeBeforeResetTimer >= TimeBeforeReset)
            {
                TimeBeforeResetTimer = 0f;
                Reset();
                ReadyToReset = false;
            }
        }
        */
    }


    public void Reset()
    {
        P1_P2_ReadyToDraw = true;
        target.position = Point1.position;
        active = false;
        DelayTimeCounter = 0;
        lineRenderer.SetPosition(1, Point1.position);
    }

    
}
