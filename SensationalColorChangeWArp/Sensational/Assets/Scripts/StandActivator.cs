using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StandActivator : MonoBehaviour 
{
    //spawn the stand
    public GameObject PreFabToMake;
    public float Cooldown = 5f;
    private float CoolDownTimer;

    public bool ReadyToActivate = true;

    public GameObject CooldownCursor;




    public float speed = 10f;
	// Use this for initialization
	void Start () 
	{
        CoolDownTimer = Cooldown;
        
	}
	
	// Update is called once per frame
	void Update () 
	{

            if (ReadyToActivate == false)
        {
            CoolDownTimer -= Time.deltaTime;
            CooldownCursor.GetComponent<Image>().fillAmount = CoolDownTimer / Cooldown ;
            //print(CoolDownTimer);
            if(CoolDownTimer <= 0)
            {
                CoolDownTimer = Cooldown;
                ReadyToActivate = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && ReadyToActivate == true)
        {
            ReadyToActivate = false;
            GameObject StandPower = (GameObject) Instantiate(PreFabToMake, transform.position, transform.rotation);
            StandPower.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

        }
       
	}
}
