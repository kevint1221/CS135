using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    public GameObject enemy;
    public GameObject explosion_effect; //explosion
    Vector3 explode_area;
    int health;

    public GameObject otherobj; //your other object 
    public string scr;// your second script name 
 

    // Start is called before the first frame update
    void Start()
    {
        health = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            enemy.GetComponent<Rigidbody>().useGravity = true;
            enemy.transform.Rotate(10f, 0, 0.5f);
            //turn off chase player script
            (otherobj.GetComponent(scr) as MonoBehaviour).enabled = false;

            Destroy(enemy, 3f);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        health -= 10;
        if(health <=0)
        {
            explode_area = enemy.transform.position + new Vector3(0f, 2f, 0f);
            GameObject impact_object = Instantiate(explosion_effect,explode_area , Quaternion.identity);
            Destroy(impact_object, 1f);
        }
    }

}
