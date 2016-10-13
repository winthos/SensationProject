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

  

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetWidth(0.2f, 0.2f);

        lineRenderer.SetPosition(0, Point1.position);
        lineRenderer.SetPosition(1, Point2.position);
        lineRenderer.SetPosition(2, Point3.position);
        lineRenderer.SetPosition(3, Point4.position);
    }

    void Update()
    {

    }
}
