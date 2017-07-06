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

    private int ShotsFiredInRoom1 = 0;
    private int ShotsFiredInRoom2 = 0;
    private int ShotsFiredInRoom3 = 0;
    private int ShotsFiredInRoom4 = 0;
    private int ShotsFiredInRoom5 = 0;
    private int ShotsFiredInRoom6 = 0;
    private int ShotsFiredInRoom7 = 0;


    public float speed = 10f;
    // Use this for initialization
    void Start()
    {
        CoolDownTimer = Cooldown;

    }

    // Update is called once per frame
    void Update()
    {

        if (ReadyToActivate == false)
        {
            CoolDownTimer -= Time.deltaTime;
            CooldownCursor.GetComponent<Image>().fillAmount = CoolDownTimer / Cooldown;
            //print(CoolDownTimer);
            if (CoolDownTimer <= 0)
            {
                CoolDownTimer = Cooldown;
                ReadyToActivate = true;
            }
        }

        if (Input.GetMouseButtonDown(0) && ReadyToActivate == true)
        {
            ReadyToActivate = false;
            GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);
            StandPower.GetComponent<Rigidbody>().velocity = transform.forward * speed;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();

            if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom1 == true)
            {
                ShotsFiredInRoom1 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom1(ShotsFiredInRoom1);
            }

            else if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom2 == true)
            {
                ShotsFiredInRoom2 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom2(ShotsFiredInRoom2);
            }

            else if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom3 == true)
            {
                ShotsFiredInRoom3 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom3(ShotsFiredInRoom3);
            }

            else if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom4 == true)
            {
                ShotsFiredInRoom4 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom4(ShotsFiredInRoom4);
            }

            else if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom5 == true)
            {
                ShotsFiredInRoom5 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom5(ShotsFiredInRoom5);
            }

            else if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom6 == true)
            {
                ShotsFiredInRoom6 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom6(ShotsFiredInRoom6);
            }

            else if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom7 == true)
            {
                ShotsFiredInRoom7 += 1;
                GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfShotsInRoom7(ShotsFiredInRoom7);
            }
        }

    }
}
