using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeWithDistance : MonoBehaviour 
{
    private MeshRenderer TutorialText;
    private GameObject Player;
    private GameObject TimeGlobal;
    public float MinimumDistance = 10f;

	// Use this for initialization
	void Start () 
	{
        TutorialText = GetComponent<MeshRenderer>();
        Player = GameObject.Find("FPSController");
        TimeGlobal = GameObject.Find("LevelGlobals");

    }
	
	// Update is called once per frame
	void Update () 
	{
        if (TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            return;
        }
        float Distance = Vector3.Distance(Player.transform.position, transform.position);

        if(Distance > MinimumDistance)
        {
            //TutorialText.GetComponent<TextMesh>().text = ""
            TutorialText.enabled = false;
        }

        if(Distance <= MinimumDistance)
        {
            TutorialText.enabled = true;
          //  TutorialText.material.SetColor("_ALPHABLEND_ON", new Color(TutorialText.material.color.r, TutorialText.material.color.g, TutorialText.material.color.b, MinimumDistance / Distance));
        }


	}
}
