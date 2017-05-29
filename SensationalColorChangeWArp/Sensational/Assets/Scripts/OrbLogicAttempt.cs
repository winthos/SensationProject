using UnityEngine;
using System.Collections;

public class OrbLogicAttempt : MonoBehaviour 
{
    [SerializeField]
    GameObject[] Positions;

    private bool IsTimeStopped;

    private int HowManyTimesHaveIBeenPunched = 0;

    public bool SomethingTouchedMe = false;

    private bool active = true;

    private float counter = 0f;

    public float MoveTime = 1f;

    public float HowLongUntilReset = 3.5f;
    private float ResetTimer = 0f;
    private bool startReset = false;

    public Material clear;
    public Material solid;

    private GameObject TimerText;

    public GameObject PrefabToSpawn;

    public bool GoalReached = false;

    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip reset;

    private bool played1 = false;
    private bool played2 = false;
    private bool played3 = false;

    private Vector3 InitialScale;

    public bool ImInRoom2 = false;
    public bool ImInRoom3 = false;
    public bool ImInRoom4 = false;
    public bool ImInRoom5 = false;
    public bool ImInRoom6 = false;
    public bool ImInRoom7 = false;

    private bool IncrementOrbLogicNow = false;

    // Use this for initialization
    void Start () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;
        transform.position = Positions[0].transform.position;
        gameObject.GetComponent<Renderer>().material = solid;

        TimerText= gameObject.transform.Find("TimerText").gameObject;
        InitialScale = gameObject.transform.localScale;
    }
	
	// Update is called once per frame
	void Update () 
	{
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;

        if (HowManyTimesHaveIBeenPunched == 1)
        {
            if (played1 == false)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(sound1);
                played1 = true;
            }
        }

        if (HowManyTimesHaveIBeenPunched == 2)
        {
            if (played2 == false)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(sound2);
                played2 = true;
            }
        }

        if (HowManyTimesHaveIBeenPunched == 3)
        {
            if (played3 == false)
            {
                gameObject.GetComponent<AudioSource>().PlayOneShot(sound3);
                played3 = true;
            }
        }

        if (IsTimeStopped == true)
        {
            return;
        }


        if (IsTimeStopped == false && startReset == true)
        {


            ResetTimer += Time.deltaTime;
            TimerText.GetComponent<TextMesh>().text = (HowLongUntilReset - ResetTimer).ToString("F2");
            //print(ResetTimer);

            //print(gameObject.transform.localScale);
         //  gameObject.transform.localScale = new Vector3((ResetTimer * 4.2f)/HowLongUntilReset, (ResetTimer * 4.2f) / HowLongUntilReset, (ResetTimer * 4.2f) / HowLongUntilReset);

            //time to reset
            if(ResetTimer >= HowLongUntilReset)
            {
                if (ImInRoom2 == true)
                {
                    GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom2();
                    //gameObject.GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom2();
                }

                if (ImInRoom3 == true)
                {
                    GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom3();
                    //gameObject.GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom3();
                }

                if (ImInRoom4 == true)
                {
                    GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom4();
                    //gameObject.GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom4();
                }

                if (ImInRoom5 == true)
                {
                    GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom5();
                    // gameObject.GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom5();
                }

                if (ImInRoom6 == true)
                {
                    GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom6();
                    // gameObject.GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom6();
                }

                if (ImInRoom7 == true)
                {
                    GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom7();
                    // gameObject.GetComponent<DataNStuff>().UpdateNumberOfSwitchResetsInRoom7();
                }

                GameObject StandPower = (GameObject)Instantiate(PrefabToSpawn, transform.position, transform.rotation);

                gameObject.GetComponent<AudioSource>().PlayOneShot(reset);
                played1 = false;
                played2 = false;
                played3 = false;


                transform.position = Positions[0].transform.position;
                HowManyTimesHaveIBeenPunched = 0;
                active = true;
                startReset = false;
                counter = 0;
                ResetTimer = 0f;
                gameObject.GetComponent<Renderer>().material = solid;
                gameObject.GetComponent<Transform>().localScale = InitialScale;
                TimerText.GetComponent<TextMesh>().text = (4.00).ToString("F2");
            }

            if(counter <= MoveTime && HowManyTimesHaveIBeenPunched == 1)
            {
                counter += Time.deltaTime;
                //print(counter);
                transform.position = Vector3.Lerp(Positions[0].transform.position, Positions[1].transform.position, counter);

                if (gameObject.transform.position == Positions[1].transform.position)
                {
                    gameObject.GetComponent<Renderer>().material = solid;
                    gameObject.GetComponent<Transform>().localScale = gameObject.transform.localScale * 2;
                    active = true;
                   // counter = 0;
                }
            }


            if (counter <= MoveTime && HowManyTimesHaveIBeenPunched == 2)
            {

                counter += Time.deltaTime;
                //print(counter);
                transform.position = Vector3.Lerp(Positions[1].transform.position, Positions[2].transform.position, counter);

                if (gameObject.transform.position == Positions[2].transform.position)
                {
                    gameObject.GetComponent<Renderer>().material = solid;
                    gameObject.GetComponent<Transform>().localScale = gameObject.transform.localScale * 2;
                    active = true;
                    // counter = 0;
                }
            }

            if (counter <= MoveTime && HowManyTimesHaveIBeenPunched == 3)
            {
  
                counter += Time.deltaTime;
                //print(counter);
                transform.position = Vector3.Lerp(Positions[2].transform.position, Positions[3].transform.position, counter);
            
                if (gameObject.transform.position == Positions[3].transform.position)
                {
                    gameObject.GetComponent<Renderer>().material = solid;
                    gameObject.GetComponent<Transform>().localScale = gameObject.transform.localScale * 2;
                    active = false;
                    startReset = false;
                    TimerText.GetComponent<TextMesh>().text = "UNLOCKED!";
                    // counter = 0;
                    GoalReached = true;
                }
            }


        }
    }

    void OnCollisionEnter(Collision col)
    {
        //check for the stand which are all tagged with DoYouUnderstand
        if (col.gameObject.tag == "DoYouUnderstand" && active == true)
        {
            SomethingTouchedMe = true;
            HowManyTimesHaveIBeenPunched++;
            print(HowManyTimesHaveIBeenPunched);
            gameObject.GetComponent<Renderer>().material = clear;
            gameObject.GetComponent<Transform>().localScale = gameObject.transform.localScale / 2;
            active = false;
            startReset = true;
            counter = 0;
    
        }
    }

}
