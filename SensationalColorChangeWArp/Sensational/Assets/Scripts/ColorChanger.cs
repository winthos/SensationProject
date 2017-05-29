using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour 
{
    private GameObject LevelGlobals;

    public bool CheckThisIfIShouldBeColoredInStoppedTime = false;
    private Color OriginalColor;
    private Color GreyScaleColor;
    private Color InvertedColor;
    // Use this for initialization
    void Start()
    {
        LevelGlobals = GameObject.Find("LevelGlobals");
        OriginalColor = gameObject.GetComponent<Renderer>().material.color;
        GreyScaleColor = new Color(OriginalColor.grayscale, OriginalColor.grayscale, OriginalColor.grayscale);
        InvertedColor = InvertColor(GreyScaleColor);

    }

    // Update is called once per frame
    void Update()
    {
        if (LevelGlobals.GetComponent<LevelGlobals>().TimeStopped == true && CheckThisIfIShouldBeColoredInStoppedTime == false)
        {
            gameObject.GetComponent<Renderer>().material.color = InvertedColor;
        }

        else
        {
            gameObject.GetComponent<Renderer>().material.color = OriginalColor;
        }
    }

    Color InvertColor(Color color)
    {
        return new Color(1.0f - color.r, 1.0f - color.g, 1.0f - color.b);
    }
}

