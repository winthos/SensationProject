using UnityEngine;
using System.Collections;

public class FadeThenDestroyMe : MonoBehaviour 
{
    private float count = 0f;
  //  private float delay = 0f;
   // private Color OriginalColor;
	// Use this for initialization
	void Start () 
	{
        //OriginalColor = gameObject.GetComponent<Renderer>().material.color;
	}
	
	// Update is called once per frame
	void Update () 
	{
        count += Time.deltaTime;

        if(count >= 0.25f)
        {
            Destroy(gameObject);
        }
	}
}
