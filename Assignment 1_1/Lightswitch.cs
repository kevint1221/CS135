using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{
    public Light light;

    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        Color red = new Color(255,0,0);
        Color green = new Color(0, 255, 0);
        Color blue = new Color(0, 0, 255);
  
        if (Input.GetKeyDown("tab"))
        {
            if (light.color == red)
            {
                light.color = green;
            }
            else if (light.color ==green)
            {
                light.color = blue;
            }

            else
            {
                light.color = red;
            }
        }
    }
}
