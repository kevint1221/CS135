using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Effect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet; //sphere in this case
    public float damage = 10f;
    public float range = 100f;
    public GameObject impact_effect; //flare
    public GameObject impact_effect2; //smoke
    public AudioSource asource; //audio object
    public AudioClip aclip;//audio effect

    Vector3 effect_area; //position to make impact_effect and audio effect

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("you hit: ");
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name != "Stealth_Bomber")
        {
            Hit_object();
            Destroy(bullet);

        }
        
    }


void Hit_object()
    {
        //hitted object
        RaycastHit hit;
        //if hit the object
        if (Physics.Raycast(bullet.transform.position, bullet.transform.forward, out hit, range))
        {
            //Display object name
           // Debug.Log(hit.transform.name);
        }
        
        effect_area = bullet.transform.position + new Vector3(0f, 1.5f, 0f);
        //create hit effect
        GameObject impact_object = Instantiate(impact_effect, effect_area, Quaternion.identity);
        GameObject impact_object2 = Instantiate(impact_effect2, effect_area, Quaternion.identity);
        //if the bullet hit the object, make explode sound
        global_variable.hit_sound_enable = true;
        //destroy hit effect after 2second
        Destroy(impact_object, 0.3f);
        Destroy(impact_object2, 3f);

        
       
    }


}
