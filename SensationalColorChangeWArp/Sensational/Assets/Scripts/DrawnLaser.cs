using UnityEngine;
using System.Collections;

public class DrawnLaser : MonoBehaviour
{
    //draws static magenta line between the points
    private LineRenderer lineRenderer;

    public Transform Point1;
    public Transform Point2;
    public Transform Point3;
    public Transform Point4;

    private GameObject LevelGLobal;

    public Material FirstColor;
    public Material SecondColor;

    void Start()

    {
        LevelGLobal = GameObject.Find("LevelGlobals");
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetWidth(0.1f, 0.1f);

        lineRenderer.SetPosition(0, Point1.position);
        lineRenderer.SetPosition(1, Point2.position);
        lineRenderer.SetPosition(2, Point3.position);
        lineRenderer.SetPosition(3, Point4.position);
    }

    void Update()
    {
        if (LevelGLobal.GetComponent<LevelGlobals>().TimeStopped == true)
        {
            gameObject.GetComponent<LineRenderer>().material = SecondColor;
        }
        if (LevelGLobal.GetComponent<LevelGlobals>().TimeStopped == false)
        {
            gameObject.GetComponent<LineRenderer>().material = FirstColor;
        }
    }
}
