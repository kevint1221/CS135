﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheep_sound : MonoBehaviour
{
    public AudioSource goat_audio_source; //audio object
    public AudioClip goat_sclip;//audio effect
    bool goat_dead;
    // Start is called before the first frame update
    void Start()
    {
        goat_dead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(global_variable.goat_scream == true)
        {
            //if(goat_dead == false)
            //{
            this.goat_audio_source.PlayOneShot(goat_sclip);
            global_variable.goat_scream = false;
            //goat_dead = true;
            //}

        }
    }

}
