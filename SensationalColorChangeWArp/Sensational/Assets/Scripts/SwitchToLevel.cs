using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SwitchToLevel : MonoBehaviour 
{
    [SerializeField]
    float countdown = 5.0f;
    [SerializeField]
    string LevelToLoad;
    [SerializeField]
    bool CountdownActive = false;


	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
        if(CountdownActive == false)
        {
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene(LevelToLoad);
            }
        }
        countdown -= Time.deltaTime;
       // string ThingToPrint = string.Format("", LevelToLoad);
       // print(ThingToPrint);
        if (countdown <= 0 && CountdownActive == true)
        {
            SceneManager.LoadScene(LevelToLoad);
        }


	}
}
