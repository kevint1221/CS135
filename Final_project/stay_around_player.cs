using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stay_around_player : MonoBehaviour
{
    int level;
    public GameObject player;
    public GameObject chase_point;
    public GameObject sheep; // level 3
    
    public float min_dist; //50f default
    
    public float move_speed; //20f default

    // Start is called before the first frame update
    void Start()
    {
        level = global_variable.level;
    }

    // Update is called once per frame
    void Update()
    {

        if (level == 2)
        {
            this.transform.LookAt(player.transform);
            if (Vector3.Distance(this.transform.position, player.transform.position) >= min_dist)
            {
                this.transform.position += this.transform.forward * move_speed * Time.deltaTime;
            }
           
        }
     
           
            
  
        
        
        


    }
}
