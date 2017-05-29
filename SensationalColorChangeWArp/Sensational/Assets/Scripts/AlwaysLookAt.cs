using UnityEngine;
using System.Collections;

public class AlwaysLookAt : MonoBehaviour 
{
    public GameObject WhereAreYou;
    public float speed = 10f;
    // Use this for initialization
    void Start () 
	{
        WhereAreYou = GameObject.Find("FPSController");
    }
	
	// Update is called once per frame
	void Update () 
	{
        Vector3 targetDir = WhereAreYou.transform.position - transform.position;
        float step = speed * Time.deltaTime;

        Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
        transform.rotation = Quaternion.LookRotation(newDir);
    }
}
