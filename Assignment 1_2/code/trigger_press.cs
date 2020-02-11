using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine.SceneManagement;

public class trigger_press : MonoBehaviour
{
    public Light light1;
    public AudioSource asource;
    public AudioClip aclip;

    void Start(){
      
    }

    void Update()
    {
        //when user press A
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("you press A");

        }
        //exit the game when user press B
        if (OVRInput.Get(OVRInput.Button.Two))
        {
            #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
            #else
                        Application.Quit();
            #endif

        }
        //reset the game if user press y
        if (OVRInput.Get(OVRInput.Button.Four))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
        //exist the game when user press esc
        if (Input.GetKeyDown(KeyCode.Escape))
        {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit();
        #endif
        }
        
        //reset the game when user press p
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        

    }

    //when someone walk inside and press A will trigger the fucntion
    private void OnTriggerStay(Collider other)
    {
        //press A and the light is not black
        if (OVRInput.Get(OVRInput.Button.One) && light1.color != new Color(0,0,0))
        {
           //change light color to black
           light1.color = new Color(0, 0, 0);
           //add the global variable score
           global_variable.score++;
           asource.PlayOneShot(aclip);
            //reset timer
            change_light.timer = 0; 
           Debug.Log(global_variable.score); 
            
            
            
            
        }

    }

   
}

