using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;
public class DamageFlashController : MonoBehaviour 
{
    private Image damageflash;

    private bool active = false;
    private float counter = 0;

    private float reset = 0.5f;
    private GameObject TimeGlobal;
    private GameObject WhereIsThePlayerOhMyGod;

    // Use this for initialization
    void Start () 
	{
        damageflash = GetComponent<Image>();
        TimeGlobal = GameObject.Find("LevelGlobals");
        WhereIsThePlayerOhMyGod = GameObject.Find("FPSController/FirstPersonCharacter");
    }
	
	// Update is called once per frame
	void Update () 
	{
        /*
	    if(active == true)
        {
            counter += Time.deltaTime;
            if(counter >= reset)
            {
                damageflash.enabled = false;
                active = false;
                counter = 0;
            }
        }   
        */
	}

    public void EnableScreen()
    {
      //  print("screen enabled");
        damageflash.enabled = true;
        active = true;
        TimeGlobal.GetComponent<LevelGlobals>().IncreaseCount();
        TimeGlobal.GetComponent<LevelGlobals>().StartTheCooldown = true;
        WhereIsThePlayerOhMyGod.GetComponent<MotionBlur>().enabled = true;

    }

    public void TurnOffScreen()
    {
        damageflash.enabled = false;
        WhereIsThePlayerOhMyGod.GetComponent<MotionBlur>().enabled = false;
    }
}
