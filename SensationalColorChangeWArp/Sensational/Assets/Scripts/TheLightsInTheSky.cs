using UnityEngine;
using System.Collections;

public class TheLightsInTheSky : MonoBehaviour
{
    private Transform transformx;
    private ParticleSystem.Particle[] points;
    private GameObject TimeGlobal;

    public int starsMax = 100;
    public float starSize = 1;
    public float starDistance = 10;
    public float starClipDistance = 1;
    private float starDistanceSquared;
    private float starClipDistanceSquared;

    // Use this for initialization
    void Start()
    {
        transformx = transform;
        starDistanceSquared = starDistance * starDistance;
        starClipDistanceSquared = starClipDistance * starClipDistance;
        TimeGlobal = GameObject.Find("LevelGlobals");
    }


    void CreateStars()
    {
        points = new ParticleSystem.Particle[starsMax];

        for (int i = 0; i < starsMax; i++)
        {
            points[i].position = Random.insideUnitSphere * starDistance + transformx.position;
            points[i].startColor = new Color(1, 1, 1, 1);
            points[i].startSize = starSize;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            GetComponent<ParticleSystem>().Pause();
        }

        if(TimeGlobal.GetComponent<LevelGlobals>().TimeStopped == false)
        {
            GetComponent<ParticleSystem>().Play();
        }
        if (points == null) CreateStars();

        for (int i = 0; i < starsMax; i++)
        {
            if ((points[i].position - transformx.position).sqrMagnitude > starDistanceSquared)
            {
                points[i].position = Random.insideUnitSphere.normalized * starDistance + transformx.position;
            }

            if ((points[i].position - transformx.position).sqrMagnitude <= starClipDistanceSquared)
            {
                float percent = (points[i].position - transformx.position).sqrMagnitude / starClipDistanceSquared;
                points[i].startColor = new Color(1, 1, 1, percent);
                points[i].startSize = percent * starSize;
            }
        }

        ParticleSystem systemthingy = GetComponent<ParticleSystem>();
        systemthingy.SetParticles(points, points.Length);
        //particleSystem.SetParticles(points, points.Length);

        if (Input.GetKeyDown("escape"))
        {
            //Cursor.lockState = CursorLockMode.None;
            Application.Quit();
        }
    }
}
