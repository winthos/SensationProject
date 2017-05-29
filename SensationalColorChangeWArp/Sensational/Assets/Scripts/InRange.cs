using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class InRange : MonoBehaviour 
{
    GameObject Canvas;
	// Use this for initialization
	void Start () 
	{
        Canvas = GameObject.Find("Canvas/CenterCursor");
	}
	
	// Update is called once per frame
	void Update () 
	{
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {

                //print(hit.distance);
           // print(hit.collider.tag);
                if (hit.distance <= 13.5 && hit.collider.tag == "StandTouch")
                {
                    //print("distance");
                    Canvas.GetComponent<Image>().enabled = true;
                }
                if (hit.distance > 13.5)
                {
                    Canvas.GetComponent<Image>().enabled = false;
                }
            

        }
    }
}
