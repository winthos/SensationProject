using UnityEngine;
using System.Collections;

public class StandMoveForward : MonoBehaviour 
{
    //collision logic for what the stand touches
    Rigidbody StandBody;
    public float ForwardSpeed = 10;
    public Vector3 ForwardDirection;

    public GameObject PreFabToMake;

    private float DespawnTimer = 0.7f;

	// Use this for initialization
	void Start () 
	{
        StandBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
        DespawnTimer -= Time.deltaTime;
        if(DespawnTimer <= 0)
        {
            
            AudioSource audio = GameObject.Find("StandInSound").GetComponent<AudioSource>();
            audio.Play();
            GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);
            Destroy(gameObject);
        }
       // StandBody.velocity = new Vector3(0, 0, ForwardSpeed);
	}

    void OnCollisionEnter (Collision col)
    {
        //print("collision is happening");
        if(col.gameObject.tag == "StandTouch")
        {
            //spawn explosion particle here?
            AudioSource audio = GameObject.Find("StandInSound").GetComponent<AudioSource>();
            audio.Play();
            GameObject StandPower = (GameObject)Instantiate(PreFabToMake, transform.position, transform.rotation);

            if (col.gameObject.name == "Projectile")
            {
                //Destroy(col.gameObject);
            }
            Destroy(gameObject);
        }
    }
}
