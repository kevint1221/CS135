using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow_sound : MonoBehaviour
{
    public AudioSource cow_audio_source; //audio object
    public AudioClip cow_sclip;//audio effect
    bool cow_dead;
    // Start is called before the first frame update
    void Start()
    {
        cow_dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (global_variable.cow_scream == true)
        {
            //if(goat_dead == false)
            //{
            this.cow_audio_source.PlayOneShot(cow_sclip);
            global_variable.cow_scream = false;
            //goat_dead = true;
            //}

        }
    }

}
