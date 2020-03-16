using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ambient_sound : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource airplane_source; //audio object
    public AudioClip airplane_clip;//audio effect
     GameObject player;
    public float min_dist = 100f;
    float counter;
    void Start()
    {
        counter = 0f;
        player = GameObject.Find("Stealth_Bomber");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Vector3.Distance(this.transform.position, player.transform.position) <= min_dist)
        {
            if (counter <= 0)
            {
                airplane_source.PlayOneShot(airplane_clip); //play sound
                counter = 4f;
            }
            counter -= Time.deltaTime;
            
        }
    }
}
