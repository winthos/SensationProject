using UnityEngine;
using System.Collections;

public class NewTimeLens : MonoBehaviour 
{
    private GameObject LevelGlobals;

    private float count = 0f;
    private float speed = 0.3f;
    private Vector3 InitialScale;

    private bool dothisonce = false;

    // Use this for initialization
    void Start()
    {
        LevelGlobals = GameObject.Find("LevelGlobals");
        InitialScale = transform.localScale;
       // transform.localScale = InitialScale;
    }

    // Update is called once per frame
    void Update()
    {
        //while time is normal
        if (LevelGlobals.GetComponent<LevelGlobals>().TimeStopped == false && dothisonce == true)
        {
          
            if (count >= speed)
            {
                gameObject.GetComponent<MeshRenderer>().enabled = false;
                dothisonce = false;
                return;
            }
            gameObject.GetComponent<MeshRenderer>().enabled = true;
            transform.localScale = Vector3.Lerp( InitialScale, Vector3.zero, count / speed);
            count += Time.deltaTime;
        }

        if (LevelGlobals.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            dothisonce = true;
            gameObject.GetComponent<MeshRenderer>().enabled = false;
            transform.localScale = Vector3.zero;
            count = 0f;
        }

    }
}
