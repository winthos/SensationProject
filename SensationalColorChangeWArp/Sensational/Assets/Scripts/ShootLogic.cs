using UnityEngine;
using System.Collections;

public class ShootLogic : MonoBehaviour 
{
    
    GameObject TimeGlobal;

    public float minimumTime = 3f;
    public float maximumTime = 6f;

    public float minProjectileSpeed = 10f;
    public float maxProjectileSpeed = 30f;

    public GameObject PreFabToMake;

    private float TimeUntilNextShot;
    private float ActualProjectileSpeed;
    private bool SlowYourRoll = false;
    private float counter = 0f;

    private AudioSource TurretSound;

    public AudioClip countdownSound;
    private float audioDelay = 0.1f;
    public AudioClip fireSound;

    public Material grey;
    public Material red;

    private Renderer Rending;

    public bool active = false;

    // Use this for initialization
    void Start () 
	{
       
        TimeGlobal = GameObject.Find("LevelGlobals");
        TurretSound = GetComponent<AudioSource>();
        Rending = GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () 
	{
        if(TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            return;
        }

        if (TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == false && active == true)
        {
            //dont roll the random unless we want to
            if(SlowYourRoll == false)
            {
                ActualProjectileSpeed = Random.Range(minProjectileSpeed, maxProjectileSpeed);
                TimeUntilNextShot = Random.Range(minimumTime, maximumTime);
                //ok we rolled the random, slow your roll
                SlowYourRoll = true;
            }

            counter += Time.deltaTime;

            //play some sounds, flash some colors
            if(counter >= TimeUntilNextShot - 1 && counter < TimeUntilNextShot)
            {
                audioDelay -= Time.deltaTime;
               // print(audioDelay);
                if(audioDelay <= 0)
                {
                    Rending.material = red;

                    TurretSound.PlayOneShot(countdownSound);
                    audioDelay = 0.1f;
                }
     
            }

            if(counter >= TimeUntilNextShot)
            {
                //time is up! shoot shoot shoot go go go volavolavolavolavola VOLAREVIA!
                GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);
                StandPower.GetComponent<Rigidbody>().velocity = transform.forward * ActualProjectileSpeed;
                TurretSound.PlayOneShot(fireSound);
                //no need to slow our roll anymore
                SlowYourRoll = false;
                counter = 0f;
                Rending.material = grey;

            }

        }
    }
}
