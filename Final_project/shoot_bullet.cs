using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_bullet : MonoBehaviour
{
    public GameObject bullet_object;
    public GameObject hitbox;
    public GameObject front_end;
    public GameObject back_end;
    public AudioSource shoot_source; //audio object
    public AudioClip shoot_clip;//audio effect
    public AudioSource hit_source;
    public AudioClip hit_clip;
    
    Vector3 bullet_position;
    Vector3 offset;
    Vector3 explosion_location;
    float right_index;
    float counter;
    GameObject bullet;

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
                bullet_position = hitbox.transform.position;// + new Vector3(0f, 0f, 3f);
                bullet = Instantiate(bullet_object, bullet_position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().velocity = 180f * offset;
                
                counter = 0.5f;
                
                shoot_source.PlayOneShot(shoot_clip); //play sound
                Destroy(bullet, 5f);
                
            }
            
        }
        counter -= Time.deltaTime;
        if(global_variable.hit_sound_enable == true)
        {
            //offset = front_end.transform.position - back_end.transform.position;
            //explosion_location = 4 * offset;
            //hit_source.transform.position += explosion_location;
            hit_source.PlayOneShot(hit_clip);
            Destroy(bullet);
            global_variable.hit_sound_enable = false;
            

        }
        //bullet.transform.position += offset;

    }
}
