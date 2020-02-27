using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase_player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject enemy;
    float move_speed = 10f;
    float max_dist = 10f;
    float min_dist = 50f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.transform.LookAt(player.transform);

        //if (Vector3.Distance(enemy.transform.position, player.transform.position) >= min_dist)
        //{

        enemy.transform.position += enemy.transform.forward * move_speed * Time.deltaTime;



            //if (Vector3.Distance(transform.position, player.transform.position) <= max_dist)
            //{
                //Here Call any function U want Like Shoot at here or something
            //}

       // }
    }
}
