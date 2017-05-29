using UnityEngine;
using System.Collections;

public class OrbCountLogic : MonoBehaviour 
{
    private GameObject TimeGlobal;
    // Use this for initialization
    private float TotalTimeSoFar;

    void Start()
    {
        TimeGlobal = GameObject.Find("LevelGlobals");
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<TextMesh>().text = "ORBS DESTROYED: " + TimeGlobal.GetComponent<LevelGlobals>().DestroyedOrbsCount;

    }
}
