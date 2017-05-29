using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayAgain : MonoBehaviour 
{
    public GameObject ResetOrb;
    //if the player touches the orb, restart the level
	// Use this for initialization
	void Start () 
	{
        
	}
	
	// Update is called once per frame
	void Update () 
	{
	    if(ResetOrb.GetComponent<OrbLogicAttempt>().SomethingTouchedMe == true)
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
	}
}
