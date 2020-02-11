using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    Vector3 original_position = Vector3.zero;
    Vector3 distance_move = Vector3.zero;
    public static int reverse;
    public GameObject parent_camera;
    public GameObject the_camera;

    int count;
    
    // Start is called before the first frame update
    void Start()
    {
        original_position = new Vector3(0.0f, 0.0f, 0.0f);
        distance_move = new Vector3(0.0f, 0.0f, 0.0f);
        reverse = 0;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //************* moving the camera ***************************
        
        if (Input.GetKeyDown("f"))
        {
            if (reverse == 0)
            {
                reverse = 1;
            }
            else
            {
                reverse = 0;
            }
            
        }
        /*
        if (reverse == 0)
        {

            float xAxisValue = Input.GetAxis("Horizontal") * Time.deltaTime;
            float zAxisValue = Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position = new Vector3(transform.position.x - xAxisValue, transform.position.y, transform.position.z - zAxisValue);
        }
        else
        {
            float xAxisValue = Input.GetAxis("Horizontal") * Time.deltaTime;
            float zAxisValue = Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + xAxisValue, transform.position.y, transform.position.z + zAxisValue);
        }
            //************* reset camera position to (0,0,0) ************
        */
    
        if (Input.GetKey("tab"))
        {

            //based on the distance main_camera moves, it would subtract the position of parent_camera to set main_camera to (0,0,0)

            distance_move = original_position - the_camera.transform.position;
            //the_camera.transform.position = original_position;
            parent_camera.transform.position += distance_move; //calculate the offset 
            
           
        }
       



        //************* exit the game *******************************
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #else
                            Application.Quit();
            #endif
        }


    }
}
