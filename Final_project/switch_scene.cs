using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class switch_scene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene(sceneName: "ground");
        }

        if (Input.GetKeyDown("j"))
        {
            SceneManager.LoadScene(sceneName: "air_level1");
        }

        //pause game
        if(Input.GetKeyDown("p"))
        {
            Time.timeScale = 0f; //pause game

            //Time.timeScale = 1f; //resume game
        }

    }
}
