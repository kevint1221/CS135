using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_bullet : MonoBehaviour
{
    public GameObject bullet_object;
    public GameObject hitbox;
    public GameObject front_end;
    public GameObject back_end;
    Vector3 bullet_position;
    Vector3 offset;
    float right_index;
    float counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {

        right_index = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
        if (counter <= 0)
        {
            if (right_index > 0.3f)
            //if(OVRInput.GetDown(OVRInput.RawButton.A))
            {
                offset = front_end.transform.position - back_end.transform.position;
                bullet_position = hitbox.transform.position + new Vector3(0f, 0f, 3f);
                GameObject bullet = Instantiate(bullet_object, bullet_position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().velocity = 100f * offset;
                
                counter = 0.5f;
                Destroy(bullet, 2f);
            }
            
        }
        counter -= Time.deltaTime;
        
        //bullet.transform.position += offset;

    }
}
