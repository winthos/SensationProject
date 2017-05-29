using UnityEngine;
using System.Collections;

public class ProjectilePlayerDetector : MonoBehaviour 
{
    public GameObject PreFabToMake;

    private GameObject Player;
    private DamageFlashController DamageFlashOnCanvas;

    public bool AmIOnCube = false;

    private bool waitTillActive = false;
    private float delay = 0;

    //public GameObject TargetProjectileToTrack;
    // Use this for initialization
    void Start () 
	{
        Player = GameObject.Find("FPSController");
        DamageFlashOnCanvas = GameObject.Find("Canvas/DamageFlash").GetComponent<DamageFlashController>();
    }
	
	// Update is called once per frame
	void Update () 
	{
        if(waitTillActive == true)
        {
            delay += Time.deltaTime;
            if(delay >= 0.5)
            {
                waitTillActive = false;
                delay = 0f;
            }
        }

        float distance = Vector3.Distance(transform.position, Player.transform.position);
        //print(distance);
        // transform.position = TargetProjectileToTrack.transform.position;
        if (Vector3.Distance(transform.position, Player.transform.position) <= 2.5 && waitTillActive == false && AmIOnCube == true)
        {
            GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfBlocksThatTouchedMe();
            GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);
            DamageFlashOnCanvas.EnableScreen();
            waitTillActive = true;

            if (AmIOnCube == false)
                Destroy(transform.parent.gameObject);
        }

        if (Vector3.Distance(transform.position, Player.transform.position) <= 1.0 && waitTillActive == false)
        {
            GameObject.Find("GlobalDataEmpty").GetComponent<DataNStuff>().UpdateNumberOfProjectilesThatTouchedMe();

            GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);
            DamageFlashOnCanvas.EnableScreen();
            waitTillActive = true;

            if(AmIOnCube == false)
            Destroy(transform.parent.gameObject);

            
        }
	}


}
