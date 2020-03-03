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
    public GameObject shoot_effect;
    public GameObject gun_front_end;

    Vector3 bullet_position;
    Vector3 offset;
    Vector3 explosion_location;
    float right_index;
    float bullet_counter;
    float effect_counter; 
   



    // Start is called before the first frame update
    void Start()
    {
        bullet_counter = 0.5f;
        
        
    }

    // Update is called once per frame
    void Update()
    {

        right_index = OVRInput.Get(OVRInput.RawAxis1D.RIndexTrigger);
        if (bullet_counter <= 0)
        {
            if (right_index > 0.3f)
            //if(OVRInput.GetDown(OVRInput.RawButton.A))
            {
                

                offset = front_end.transform.position - back_end.transform.position;
                bullet_position = hitbox.transform.position;// + new Vector3(0f, 0f, 3f);
                GameObject bullet = Instantiate(bullet_object, bullet_position, Quaternion.identity);
                bullet.transform.rotation = hitbox.transform.rotation;
                bullet.GetComponent<Rigidbody>().velocity = 500f * offset;

                //create visual effect when shoot
                Vector3 effect_area = gun_front_end.transform.position + 0.1f * gun_front_end.transform.forward;
                //gun_front_end.transform.forward;
                GameObject effect_object = Instantiate(shoot_effect, effect_area, Quaternion.identity);
                Destroy(effect_object, 0.1f);
                //create vibration
                Shoot_vibrate();
                
                bullet_counter = 0.5f;
                
                shoot_source.PlayOneShot(shoot_clip); //play sound
                Destroy(bullet, 5f);
                
            }
            
        }
        bullet_counter -= Time.deltaTime;

        if(effect_counter <=0)
        {
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
        }
        effect_counter -= Time.deltaTime;

        if (global_variable.hit_sound_enable == true)
        {
            //offset = front_end.transform.position - back_end.transform.position;
            //explosion_location = 4 * offset;
            //hit_source.transform.position += explosion_location;
            hit_source.PlayOneShot(hit_clip);
            //Destroy(bullet);
            global_variable.hit_sound_enable = false;
            

        }
        //bullet.transform.position += offset;

    }

    //vibrate when shoot
    void Shoot_vibrate()
    {

        OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);
        effect_counter = 0.3f;

    }

    //delay function
    

}

