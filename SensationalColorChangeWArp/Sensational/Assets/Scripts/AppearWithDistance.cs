using UnityEngine;
using System.Collections;

public class AppearWithDistance : MonoBehaviour 
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

        if (Distance > MinimumDistance)
        {
            //TutorialText.GetComponent<TextMesh>().text = ""
            TutorialText.enabled = true;
        }

        if (Distance <= MinimumDistance)
        {
            TutorialText.enabled = false;
            //  TutorialText.material.SetColor("_ALPHABLEND_ON", new Color(TutorialText.material.color.r, TutorialText.material.color.g, TutorialText.material.color.b, MinimumDistance / Distance));
        }

    }
}
