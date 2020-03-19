using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase_player : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject chase_point;
    public GameObject enemy;
    public float move_speed = 10f;
    float max_dist = 10f;
    float min_dist = 50f;


    void Start()
    {
        if(enemy.gameObject.name == "lv3_cannon" || enemy.gameObject.name == "lv3_cannon(Clone)")
        {
            chase_point = GameObject.Find("chase_point");
        }
        else if (enemy.gameObject.name == "lv1_minion(Clone)" || enemy.gameObject.name == "lv1_minion")
        {
            chase_point = GameObject.Find("spin point");
        }
        else if (enemy.gameObject.name == "lv1_cannon(Clone)" || enemy.gameObject.name == "lv1_cannon")
        {
            chase_point = GameObject.Find("z spin");
        }
        
        
    }
    // Update is called once per frame
    void Update()
    {
        enemy.transform.LookAt(chase_point.transform);

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
