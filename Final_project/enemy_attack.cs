using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    
    float min_dist;
    float counter;
    Vector3 bullet_position;
    Vector3 aim_player;
    public GameObject bullet_object;
    float plane_size; //0.5 for big aircraft  , this is the position of bullet initiate
    float bullet_speed;


    void Start()
    {

        player = GameObject.Find("Stealth_Bomber");
        counter = this.GetComponent<EnemyStats>().attack_speed; //attack every time second
        bullet_speed = this.GetComponent<EnemyStats>().bullet_speed; //attack every time second
        plane_size = this.GetComponent<EnemyStats>().plane_size; //attack every time second
        min_dist = this.GetComponent<EnemyStats>().player_range; //attack every time second
        //Debug.Log(bullet_speed);

    }

    // Update is called once per frame
    void Update()
    {
        //if player are close in range, attack player
        if (Vector3.Distance(this.transform.position, player.transform.position) <= min_dist)
        {
            if (counter <= 0)
            {

                aim_player = player.transform.position - this.transform.position; //vecyor point to player

                if (this.gameObject.name == "boss")
                {
                    bullet_position = this.transform.position + new Vector3(0, 20f, 0) + 50 * plane_size * aim_player.normalized;
                }
                else
                {
                    bullet_position = this.transform.position +  100 * plane_size * aim_player.normalized;
                }
                    
              
                
                GameObject bullet = Instantiate(bullet_object, bullet_position, Quaternion.identity);
                bullet.GetComponent<Bullet_Effect>().damage = this.GetComponent<EnemyStats>().damage;
                bullet.transform.rotation = this.transform.rotation;
                if(this.gameObject.name == "boss")
                {
                    bullet.GetComponent<Rigidbody>().velocity = 70 * bullet_speed * (aim_player.normalized - new Vector3(0, 0.15f, 0));
                }
                else
                {
                    bullet.GetComponent<Rigidbody>().velocity = 500 * bullet_speed * aim_player.normalized;
                }
                
                counter = this.GetComponent<EnemyStats>().attack_speed; //attack every time second; //resetS

                Destroy(bullet, 4f);
            }
            else
            {
                counter -= Time.deltaTime;
            }
        }


    }
}