using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class change_light : MonoBehaviour
{
    // Start is called before the first frame update
    public Light light1;
    public Light light2;
    public Light light3;
    public Light light4;
    public static float timer;
    public int select;
    public AudioSource asource;
    public AudioClip aclip;

    void Start()
    {
        select = 1;
        timer = 3.0f; //three second
        light1.color = new Color(0,0,0);
        light2.color = new Color(0,0,0);
        light3.color = new Color(0,0,0);
        light4.color = new Color(0,0,0);

        //start the function at 2 second, run the function every 3 second 
        //InvokeRepeating("changing_light", 3,  4);
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0) //need to be <= 0 because it is a float and update call each frame
        {
            changing_light();
            timer = 3;
        }
        
    }

    void changing_light()
    {
        //select random number from 1 to 4,  not sure why not 5 ??
        int temp_select = Random.Range(1,5);
        Debug.Log(temp_select);
        while (temp_select == select)
        {
            temp_select = Random.Range(1, 5);
        }
        select = temp_select;
        Debug.Log(select);
        switch (select)
        {
            case 1:
                light1.color = new Color(43,153,173);
                light2.color = new Color(0,0,0);
                light3.color = new Color(0,0,0);
                light4.color = new Color(0,0,0);
                asource.PlayOneShot(aclip);
                break;
            case 2:
                light2.color = new Color(43,153,173);
                light1.color = new Color(0,0,0);
                light3.color = new Color(0,0,0);
                light4.color = new Color(0,0,0);
                asource.PlayOneShot(aclip);
                break;
            case 3:
                light3.color = new Color(43,153,173);
                light1.color = new Color(0,0,0);
                light2.color = new Color(0,0,0);
                light4.color = new Color(0,0,0);
                asource.PlayOneShot(aclip);
                break;
            case 4:
                light4.color = new Color(43,153,173);
                light1.color = new Color(0,0,0);
                light2.color = new Color(0,0,0);
                light3.color = new Color(0,0,0);
                asource.PlayOneShot(aclip);
                break;
            default:
                break;
            
        }
    }
    
}


