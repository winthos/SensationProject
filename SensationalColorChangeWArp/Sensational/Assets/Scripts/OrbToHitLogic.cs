using UnityEngine;
using System.Collections;

public class OrbToHitLogic : MonoBehaviour 
{
    [SerializeField]
    GameObject[] Positions;

    private float Pos1Pos2Dist;
    private float Pos2Pos3Dist;
    private float Pos3Pos4Dist;

    private bool IsTimeStopped;
    private bool ReadyToBeHit = true;

    private int HowManyTimesHaveIBeenPunched = 0;

    public float TotalMovementTime = 1.0f;
    public int TargetElement;
    private float countup;

    private int currentElement;
    

	// Use this for initialization
	void Start () 
	{
       
        Pos1Pos2Dist = Vector3.Distance(Positions[0].transform.position, Positions[1].transform.position);
        Pos2Pos3Dist = Vector3.Distance(Positions[1].transform.position, Positions[2].transform.position);
        Pos3Pos4Dist = Vector3.Distance(Positions[2].transform.position, Positions[3].transform.position);

        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;

        transform.position = Positions[0].transform.position;
    }
	
	// Update is called once per frame
	void Update () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;

        if (IsTimeStopped == true)
        {
            
            return;
        }

        if(IsTimeStopped == false)
        {
            if (HowManyTimesHaveIBeenPunched > 0 && currentElement != TargetElement)
            {
                if (countup < TotalMovementTime)
                {
                    countup += Time.deltaTime;
                    //print(countup);
                }

                float percent = countup;

                //move halfway
                if (countup < TotalMovementTime)
                {
                    transform.position = Vector3.Lerp(Positions[currentElement].transform.position, Positions[currentElement + 1].transform.position, percent);
                }

                //finished moving to the next element position
                if (countup >= TotalMovementTime)
                {
                    currentElement++;
                    countup = 0;
                    HowManyTimesHaveIBeenPunched--;
                }

            }
            else if (currentElement > 0 && currentElement != TargetElement)
            {
              
                if (countup < TotalMovementTime)
                {
                    countup += Time.deltaTime;
                    //print(countup);
                }
                float percent = countup;
                if (countup < TotalMovementTime )
                {
                    transform.position = Vector3.Lerp(Positions[currentElement].transform.position, Positions[currentElement - 1].transform.position, percent);
                }
                if (countup >= TotalMovementTime)
                {
                    //print(currentElement);
                    currentElement--;
                    if (currentElement == 0)
                        ReadyToBeHit = true;
                    countup = 0;
                }
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        //check for the stand which are all tagged with DoYouUnderstand
        if (col.gameObject.tag == "DoYouUnderstand")
        {
            ///print("ORA!");
            ///
            if(ReadyToBeHit == true)
            {
                HowManyTimesHaveIBeenPunched++;
              // print(HowManyTimesHaveIBeenPunched);
            }

            //time is normal
            if(IsTimeStopped == false)
            {
                ReadyToBeHit = false;
            }
        }
    }
}
