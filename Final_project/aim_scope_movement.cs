using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aim_scope_movement : MonoBehaviour
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
        float scale = 0.1f;
        right_stick = OVRInput.Get(OVRInput.RawAxis2D.RThumbstick);
        if (right_stick.y > 0.0f)
        {
            if(right_stick.y < scale)
            {
                hitbox.transform.Rotate(0f, scale, 0f);
            }
            else if(right_stick.y < 2 * scale)
            {
                hitbox.transform.Rotate(0f, 2 * scale, 0f);
            }
            else if (right_stick.y < 4 * scale)
            {
                hitbox.transform.Rotate(0f, 4 * scale, 0f);
            }
            else if (right_stick.y < 6 * scale)
            {
                hitbox.transform.Rotate(0f, 6 * scale, 0f);
            }
            else if (right_stick.y < 8 * scale)
            {
                hitbox.transform.Rotate(0f, 8 * scale, 0f);
            }
            else if (right_stick.y < 10 * scale)
            {
                hitbox.transform.Rotate(0f, 10 * scale, 0f);
            }
        }
            
        
        if(right_stick.y < 0.0f)
        {
            if (right_stick.y > -scale)
            {
                hitbox.transform.Rotate(0f, -scale, 0f);
            }
            else if(right_stick.y > 2 * -scale)
            {
                hitbox.transform.Rotate(0f, 2 * -scale, 0f);
            }
            else if (right_stick.y > 4 * -scale)
            {
                hitbox.transform.Rotate(0f, 4 * -scale, 0f);
            }
            else if (right_stick.y > 6 * -scale)
            {
                hitbox.transform.Rotate(0f, 6 * -scale, 0f);
            }
            else if (right_stick.y > 8 * -scale)
            {
                hitbox.transform.Rotate(0f, 8 * -scale, 0f);
            }
            else if(right_stick.y > 10 * -scale)
            {
                hitbox.transform.Rotate(0f, 10 * -scale, 0f);
            }     
        }

        if(right_stick.x > 0.0f)
        {
            if(right_stick.x < scale)
            {
                hitbox.transform.Rotate(scale, 0f, 0f);
            }
            else if(right_stick.x < 2 * scale)
            {
                hitbox.transform.Rotate(2 * scale, 0f, 0f);
            }
            else if (right_stick.x < 4 * scale)
            {
                hitbox.transform.Rotate(4 * scale, 0f, 0f);
            }
            else if (right_stick.x < 6 * scale)
            {
                hitbox.transform.Rotate(6 * scale, 0f, 0f);
            }
            else if (right_stick.x < 8 * scale)
            {
                hitbox.transform.Rotate(8 * scale, 0f, 0f);
            }
            else if (right_stick.x < 10 * scale)
            {
                hitbox.transform.Rotate(10 * scale, 0f, 0f);
            }
            

        }
        if(right_stick.x < 0.0f)
        {
            if(right_stick.x > -scale)
            {
                hitbox.transform.Rotate(-scale, 0f, 0f);
            }
            else if(right_stick.x > 2 * -scale)
            {
                hitbox.transform.Rotate(2 * -scale, 0f, 0f);
            }
            else if (right_stick.x > 4 * -scale)
            {
                hitbox.transform.Rotate(4 * -scale, 0f, 0f);
            }
            else if (right_stick.x > 6 * -scale)
            {
                hitbox.transform.Rotate(6 * -scale, 0f, 0f);
            }
            else if (right_stick.x > 8 * -scale)
            {
                hitbox.transform.Rotate(8 * -scale, 0f, 0f);
            }
            else if (right_stick.x > 10 * -scale)
            {
                hitbox.transform.Rotate(10 * -scale, 0f, 0f);

            }
            
        }
    }
}
