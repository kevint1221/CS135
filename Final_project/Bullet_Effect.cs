using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Effect : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet; //sphere in this case
    public float damage =10f;
    public float range = 100f;
    public GameObject impact_effect; //flare
    public GameObject impact_effect2; //smoke
    public AudioSource asource; //audio object
    public AudioClip aclip;//audio effect
    
    Vector3 effect_area; //position to make impact_effect and audio effect

    void OnTriggerEnter(Collider other)
    {
        Shoot();
    }


    void Shoot()
    {
        //hitted object
        RaycastHit hit;
        //if hit the object
        if(Physics.Raycast(bullet.transform.position, bullet.transform.forward, out hit, range))
        {
            //Display object name
            Debug.Log(hit.transform.name);
        }
        effect_area = bullet.transform.position + new Vector3(0f, 2f, 0f);
        //create hit effect
        GameObject impact_object = Instantiate(impact_effect, effect_area, Quaternion.LookRotation(hit.normal));
        GameObject impact_object2 = Instantiate(impact_effect2, effect_area, Quaternion.LookRotation(hit.normal));
        //destroy hit effect after 2second
        Destroy(impact_object, 4f);
        Destroy(impact_object2, 4f);

        //if the bullet hit the object, make explode sound
        asource.transform.position = effect_area
        asource.PlayOneShot(aclip); //play sound
    }

    
}




