using UnityEngine;
using System.Collections;

public class BillboardFadeInWithDistance : MonoBehaviour 
{

    private MeshRenderer Render;
    private GameObject Player;

    public float MinimumDistance = 10f;

    // Use this for initialization
    void Start()
    {
        Render = GetComponent<MeshRenderer>();
        Player = GameObject.Find("FPSController");

    }

    // Update is called once per frame
    void Update()
    {
        float Distance = Vector3.Distance(Player.transform.position, transform.position);

        if (Distance > MinimumDistance)
        {
            Render.enabled = false;
        }

        if (Distance <= MinimumDistance)
        {
            Render.enabled = true;
            Render.material.SetColor("_Color", new Color(Render.material.color.r, Render.material.color.g, Render.material.color.b, MinimumDistance / Distance));
            //  TutorialText.material.SetColor("_ALPHABLEND_ON", new Color(TutorialText.material.color.r, TutorialText.material.color.g, TutorialText.material.color.b, MinimumDistance / Distance));
        }


    }
}
