using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Effect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet; //sphere in this case
    public float damage;
    public float range = 100f;
    public GameObject impact_effect; //flare
    public GameObject impact_effect2; //smoke
    GameObject object_hit;
    
    
   

    Vector3 effect_area; //position to make impact_effect and audio effect

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("you hit: ");
        //Debug.Log(other.gameObject.name);
        //if (other.gameObject.name != "Stealth_Bomber")
       // {
            object_hit = other.gameObject;
            Hit_object();
           // Debug.Log(damage);
            Destroy(bullet);
     //   }
      

        
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
        impact_object.transform.parent = object_hit.transform;
        impact_object2.transform.parent = object_hit.transform;
        //if the bullet hit the object, make explode sound
        if(object_hit.name == "enemy_lv3")
        {
            global_variable.hit_goat = true;

        }
        else
        {
            global_variable.hit_sound_enable = true;
        }
        
        //destroy hit effect after 2second
        Destroy(impact_object, 3f);
        Destroy(impact_object2, 3f);

        
       
    }


}
