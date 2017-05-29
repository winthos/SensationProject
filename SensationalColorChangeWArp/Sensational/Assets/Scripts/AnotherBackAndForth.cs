using UnityEngine;
using System.Collections;

public class AnotherBackAndForth : MonoBehaviour 
{
    public Transform[] keyPoints;
    public float speed;
    private int currentKeyPoint;
    private bool IsTimeStopped;

    private float counter = 0f;
    private float SlowDownDuration = 0.5f;
    private float newspeed;

    private bool stoptimeLerpdone = false;
    private bool normaltimeLerpdone = false;

    public bool ImADangerCubeChangeThis = false;

    public GameObject warp1;
    public GameObject warp2;
    public GameObject warp3;
    public GameObject warp4;

    public bool NoWarp = false;

    // Use this for initialization
    void Start()
    {
        transform.position = keyPoints[0].position;
        currentKeyPoint = 1;
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        newspeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        if(IsTimeStopped == true)
        {
            if(NoWarp == false)
            {
                warp1.GetComponent<MeshRenderer>().enabled = true;
                warp2.GetComponent<MeshRenderer>().enabled = true;
                warp3.GetComponent<MeshRenderer>().enabled = true;
                warp4.GetComponent<MeshRenderer>().enabled = true;
            }


            normaltimeLerpdone = false;
            //quadratic ease from whatever my speed is to 0 speed.
            //stop easing and maintain speed at 0 once done
            //t = current time = counter
            //b = beginning value = current speed, starts of = to speed
            //c = change between the beginning and destination = speed - 0, so speed
            //d total time of the tween = 1.0f seconds

            if(counter >= SlowDownDuration)
            {
                stoptimeLerpdone = true;
                newspeed = 0;
                if(ImADangerCubeChangeThis == true)
                {
                    newspeed = speed / GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeSlowScale;
                }
                counter = 0f;
                return;
            }
            //c * (t/d) +b
            //currentSpeed = speed * (counter / 1.0f) + current speed

            if(stoptimeLerpdone == false)
            {
                newspeed = Mathf.Lerp(speed, 0, counter / SlowDownDuration);
                counter += Time.deltaTime;
            }

            //print(newspeed);
            //print(counter);
           // return;
        }

        if(IsTimeStopped == false)
        {
            if(NoWarp == false)
            {
                warp1.GetComponent<MeshRenderer>().enabled = false;
                warp2.GetComponent<MeshRenderer>().enabled = false;
                warp3.GetComponent<MeshRenderer>().enabled = false;
                warp4.GetComponent<MeshRenderer>().enabled = false;
            }

            stoptimeLerpdone = false;
            //quadratic ease from 0 up to my speed
            //maintain speed and stop ease once we reach it.
            if (counter >= SlowDownDuration)
            {
                normaltimeLerpdone = true;
                newspeed = speed;
                counter = 0f;
                return;
            }

            if(normaltimeLerpdone == false)
            {
                newspeed = Mathf.Lerp(0, speed, counter / SlowDownDuration);
                counter += Time.deltaTime;
            }

        }

        if (transform.position == keyPoints[currentKeyPoint].position)
        {
            currentKeyPoint++;
        }

        if (currentKeyPoint >= keyPoints.Length)
        {
            currentKeyPoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, keyPoints[currentKeyPoint].position, newspeed * Time.deltaTime);
    }
}
