using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CheatTransport : MonoBehaviour 
{
    /*
    public bool Beginning = false;
    public bool FirstJumpArea = false;
    public bool CaveArea = false;
    public bool Mountain = false;
    public bool SunLightYellow = false;

    public bool NONONO = false;
    */
    Transform PlayerPosition;

    // Use this for initialization
    void Start()
    {
        PlayerPosition = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            PlayerPosition.position = new Vector3(3.18f, -1.61f, -22.426f);
        }

        if (Input.GetKeyDown("2"))
        {
            PlayerPosition.position = new Vector3(2.23f, -2.8f, 58.7f);
        }

        if (Input.GetKeyDown("3"))
        {
            PlayerPosition.position = new Vector3(2f, -3f, 143f);
        }

        if (Input.GetKeyDown("4"))
        {
            PlayerPosition.position = new Vector3(1f, -3f, 224f);
        }

        if(Input.GetKeyDown("5"))
        {
            PlayerPosition.position = new Vector3(0.5f, -19f, 310f);
        }

        if (Input.GetKeyDown("6"))
        {
            PlayerPosition.position = new Vector3(0.5f, -19f, 394f);
        }

        if (Input.GetKeyDown("7"))
        {
            PlayerPosition.position = new Vector3(0.5f, -19f, 470f);
        }
        if (Input.GetKeyDown("8"))
        {
            PlayerPosition.position = new Vector3(0.5f, -19f, 650f);
        }

        if (Input.GetKeyDown("0"))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }
        
        /////////
        /*
        if (NONONO == true)
            return;

        if (Beginning == true && NONONO == false)
        {
            PlayerPosition.position = new Vector3(3.7f, 0.95f, -4.6f);
            NONONO = true;
        }

        else if (FirstJumpArea == true && NONONO == false)
        {
            PlayerPosition.position = new Vector3(139f, 26f, 78f);
            NONONO = true;
        }

        else if (CaveArea == true && NONONO == false)
        {
            PlayerPosition.position = new Vector3(157f, 60.8f, 89.6f);
            NONONO = true;
        }

        else if (Mountain == true && NONONO == false)
        {
            PlayerPosition.position = new Vector3(380f, 170f, 155.59f);
            NONONO = true;
        }

        else if (SunLightYellow == true && NONONO == false)
        {
            PlayerPosition.position = new Vector3(768f, 373f, 405f);
            NONONO = true;
        }
        */
        //53, -11-, 9.4
    }
}
