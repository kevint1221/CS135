using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_health : MonoBehaviour
{
    public GameObject enemy;
    public GameObject explosion_effect; //explosion
    Vector3 explode_area;
    bool alive;
    bool add_kill;
    public float health;

    public string chase;// your second script name 
    public string enemy_attack;// your second script name 


    // Start is called before the first frame update
    void Start()
    {
        alive = true;
        add_kill = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {

            this.GetComponent<Rigidbody>().useGravity = true;
            this.transform.Rotate(1f, 0, 0.5f);
            //turn off chase player script
            (this.GetComponent(chase) as MonoBehaviour).enabled = false; //turn off chase enemy script so it can rotate properly



            (this.GetComponent(enemy_attack) as MonoBehaviour).enabled = false; //turn off enemy attack so it die won't attack
            alive = false;
            if (alive == false)
            {
                if(add_kill == true)
                {
                    global_variable.enemy_kill++;
                    add_kill = false;
                    //Debug.Log(global_variable.enemy_kill);
                }
            }
            if(this.gameObject.name == "enemy_lv3")
            {
                global_variable.goat_lv2_circle_alive = false;
            }
            
            Destroy(this.gameObject, 10f); //make sure to do this.gameobject

        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        health -= 10;
        Debug.Log("lose health");
        if(health <=0)
        {
            
            explode_area = enemy.transform.position + new Vector3(0f, 2f, 0f);
            GameObject impact_object = Instantiate(explosion_effect,explode_area , Quaternion.identity);
            Destroy(impact_object, 1f);
            
            //health = 1000;
        }
    }

}
