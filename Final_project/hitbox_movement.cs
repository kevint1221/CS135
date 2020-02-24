using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox_movement : MonoBehaviour
{
    public GameObject hitbox;
    Vector2 right_stick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        right_stick = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        if (right_stick.y > 0.0f)
        {
            if(right_stick.y < 0.3f)
            {
                hitbox.transform.Rotate(0f, 0.3f, 0f);
            }
            else if (right_stick.y < 0.6f)
            {
                hitbox.transform.Rotate(0f, 0.6f, 0f);
            }
            else
            {
                hitbox.transform.Rotate(0f, 1f, 0f);
            }
        }
            
        
        if(right_stick.y < 0.0f)
        {
            if (right_stick.y > -0.3)
            {
                hitbox.transform.Rotate(0f, -0.3f, 0f);
            }
            else if(right_stick.y > -0.6)
            {
                hitbox.transform.Rotate(0f, -0.6f, 0f);
            }
            else
            {
                hitbox.transform.Rotate(0f, -1f, 0f);
            }
            
            
        }
        if(right_stick.x > 0.0f)
        {
            if(right_stick.x < 0.3f)
            {
                hitbox.transform.Rotate(0.3f, 0f, 0f);
            }
            else if(right_stick.x < 0.6f)
            {
                hitbox.transform.Rotate(0.6f, 0f, 0f);
            }
            else
            {
                hitbox.transform.Rotate(1f, 0f, 0f);
            }
            

        }
        if(right_stick.x < 0.0f)
        {
            if(right_stick.x > -0.3f)
            {
                hitbox.transform.Rotate(-0.3f, 0f, 0f);
            }
            else if(right_stick.x > -0.6f)
            {
                hitbox.transform.Rotate(-1f, 0f, 0f);
            }
            else
            {
                hitbox.transform.Rotate(-1f, 0f, 0f);

            }
            
        }
    }
}
