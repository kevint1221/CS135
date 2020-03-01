using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject enemy;
    float range = 100f;
    float counter;
    Vector3 bullet_position;
    Vector3 aim_player;
    GameObject bullet;
    public GameObject bullet_object;
    void Start()
    {
        counter = 2f; //attack every time second
    }

    // Update is called once per frame
    void Update()
    {
        //if player are close in range, attack player
        if (Vector3.Distance(enemy.transform.position, player.transform.position) <=range)
        {
            if (counter <= 0)
            {

                aim_player = player.transform.position - enemy.transform.position; //vecyor point to player
               bullet_position = enemy.transform.position + 0.1f * aim_player;
                GameObject bullet = Instantiate(bullet_object, bullet_position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().velocity = aim_player;
                counter = 2f; //resetS
                Destroy(bullet, 4f);
            }
            else
            {
                counter -= Time.deltaTime;
            }
        }
        
        
    }
}
