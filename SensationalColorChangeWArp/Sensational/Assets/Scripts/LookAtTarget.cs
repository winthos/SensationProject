using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour 
{
    private bool IsTimeStopped;
    public GameObject WhereAreYou;

    public float speed = 5f;
    public float Range = 30f;

    // Use this for initialization
    void Start()
    {
       WhereAreYou = GameObject.Find("FPSController");
    }

    // Update is called once per frame
    void Update()
    {
        IsTimeStopped = GameObject.Find("LevelGlobals").GetComponent<LevelGlobals>().TimeStopped;

        if (IsTimeStopped == true)
        {
            return;
        }

        if (IsTimeStopped == false)
        {
            if(Vector3.Distance(transform.position, WhereAreYou.transform.position) <= Range)
            {
                gameObject.GetComponent<ShootLogic>().active = true;
                //transform.LookAt(WhereAreYou.transform);
                Vector3 targetDir = WhereAreYou.transform.position - transform.position;
                float step = speed * Time.deltaTime;

                Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0f);
                transform.rotation = Quaternion.LookRotation(newDir);
            }

            else if(Vector3.Distance(transform.position, WhereAreYou.transform.position) >= Range)
            {
                gameObject.GetComponent<ShootLogic>().active = false;
            }

        }
       

    }
}
