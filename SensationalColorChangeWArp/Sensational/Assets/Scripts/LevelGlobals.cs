using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;

public class LevelGlobals : MonoBehaviour 
{
    public bool TimeStopped = false;
    public int HitCount = 0;
    public int TimeStopCount = 0;
    public int DestroyedOrbsCount = 0;

    private int StopCounter = 0;
    private float StopCountDuration = 0;

    public float StopCountCooldown;

    private GameObject CooldownBlocks;

    private Text cooldowntext;

    public bool StartTheCooldown = false;

    private bool dothisonce = false;

    public float TimeSlowScale = 10f;

    private GameObject WhereIsThePlayerOhMyGod;

    public Texture NormalGreyscale;
    public Texture ColorGreyscale;

    private float greyscalecounter = 0f;
	// Use this for initialization
	void Start () 
	{
        CooldownBlocks = GameObject.Find("Canvas");
        cooldowntext = GameObject.Find("Canvas/CooldownText").GetComponent<Text>();
        cooldowntext.color = Color.green;
        WhereIsThePlayerOhMyGod = GameObject.Find("FPSController/FirstPersonCharacter");
    }
	
	// Update is called once per frame
	void Update () 
	{
        if(TimeStopped == true)
        {
            if(greyscalecounter < 0.1)
            greyscalecounter += Time.deltaTime;

            if(greyscalecounter >= 0.1)
            {
                WhereIsThePlayerOhMyGod.GetComponent<Grayscale>().enabled = false;
                //  WhereIsThePlayerOhMyGod.GetComponent<Grayscale>().textureRamp = NormalGreyscale;
            }
        }
        if(TimeStopped == false)
        {
            greyscalecounter = 0f;
            WhereIsThePlayerOhMyGod.GetComponent<Grayscale>().enabled = false;
            //WhereIsThePlayerOhMyGod.GetComponent<TiltShift>().enabled = false;
        }
        if (StartTheCooldown == true)
        {
            TimeStopped = false;
            StopCountDuration += Time.deltaTime;
            //cooldowntext.enabled = true;
            if (dothisonce == false)
            {
                //play the recharge sound once
                GameObject.Find("FPSController/rechargesound").GetComponent<AudioSource>().Play();
                dothisonce = true;
            }
            cooldowntext.color = Color.red;
            cooldowntext.text = "COOLDOWN: " + (4 - StopCountDuration).ToString("F2");

            if (StopCountDuration >= StopCountCooldown)
            {
                GameObject.Find("FPSController/rechargedone").GetComponent<AudioSource>().Play();
                StopCounter = 0;
                StopCountDuration = 0;
                //cooldowntext.enabled = false;
                cooldowntext.color = Color.green;
                cooldowntext.text = "TIME STOP READY";
                dothisonce = false;
                StartTheCooldown = false;
                GameObject.Find("Canvas/DamageFlash").GetComponent<DamageFlashController>().TurnOffScreen();

            }
        }
        /*
        if(StopCounter == 4 && TimeStopped == false)
        {
            StopCountDuration += Time.deltaTime;
            GameObject.Find("Canvas/cooldown1").GetComponent<Image>().enabled = false;
            GameObject.Find("Canvas/cooldown2").GetComponent<Image>().enabled = false;
            GameObject.Find("Canvas/cooldown3").GetComponent<Image>().enabled = false;
            GameObject.Find("Canvas/cooldown4").GetComponent<Image>().enabled = false;

            //cooldowntext.enabled = true;
            if(dothisonce == false)
            {
                //play the recharge sound once
                GameObject.Find("FPSController/rechargesound").GetComponent<AudioSource>().Play();
                dothisonce = true;
            }
            cooldowntext.color = Color.red;
            cooldowntext.text = "COOLDOWN: " + (4 - StopCountDuration).ToString("F2");

            if (StopCountDuration >= StopCountCooldown)
            {
                GameObject.Find("FPSController/rechargedone").GetComponent<AudioSource>().Play();
                StopCounter = 0;
                StopCountDuration = 0;
                //cooldowntext.enabled = false;
                cooldowntext.color = Color.green;
                cooldowntext.text = "TIME STOP READY";
                dothisonce = false;

            }
        }
        */
        if (Input.GetMouseButtonDown(1) && TimeStopped == false && StopCounter != 4)
        {
            TimeStopped = true;
          //  WhereIsThePlayerOhMyGod.GetComponent<TiltShift>().enabled = true;
            WhereIsThePlayerOhMyGod.GetComponent<Grayscale>().enabled = true;
            WhereIsThePlayerOhMyGod.GetComponent<Grayscale>().textureRamp = ColorGreyscale;
            TimeStopCount++;
           // StopCounter++;
            /*
            if (StopCounter == 1)
            {
                GameObject.Find("Canvas/cooldown1").GetComponent<Image>().enabled = true;
            }
            if (StopCounter == 2)
            {
                GameObject.Find("Canvas/cooldown2").GetComponent<Image>().enabled = true;
            }
            if (StopCounter == 3)
            {
                GameObject.Find("Canvas/cooldown3").GetComponent<Image>().enabled = true;
            }
            if (StopCounter == 4)
            {
                GameObject.Find("Canvas/cooldown4").GetComponent<Image>().enabled = true;
            }
            */
        }
        else if(Input.GetMouseButtonDown(1) && TimeStopped == true)
        {
            TimeStopped = false;
        }

        if(Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }
        
	}

    public void IncreaseCount()
    {
        HitCount += 1;
    }
}
