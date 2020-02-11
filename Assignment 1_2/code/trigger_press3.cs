using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger_press3 : MonoBehaviour
{
    public Light light3;
    public AudioSource asource;
    public AudioClip aclip;
    void Start(){
    }

    void Update()
    {
    }

    private void OnTriggerStay(Collider other)
    {

        if (OVRInput.Get(OVRInput.Button.One) && light3.color != new Color(0,0,0))
        {
            
            light3.color = new Color(0, 0, 0);
            global_variable.score++;
            asource.PlayOneShot(aclip);
            //reset timer
            change_light.timer = 0;
            Debug.Log(global_variable.score); 
            
            
            
            
        }

    }
}
