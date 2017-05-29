using UnityEngine;
using System.Collections;

public class MoveToPosition : MonoBehaviour 
{
    public Transform target;

    //move the node objects to each of the four positions with this sucker
	// Use this for initialization
	void Start () 
	{
        transform.position = target.position;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
