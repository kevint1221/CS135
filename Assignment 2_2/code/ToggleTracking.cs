using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTracking : MonoBehaviour
{
    public GameObject main_camera;
    public GameObject parent_camera;
    bool position_enable = true;
    bool rotation_enable = true;
    Vector3 original_position = Vector3.zero;
    Vector3 distance_move = Vector3.zero;

    Vector3 original_main_camera_position;
    Vector3 original_parent_camera_position;
    // Start is called before the first frame update
    void Start()
    {
        original_position = new Vector3(0.0f, 0.0f, 0.0f);
        distance_move = new Vector3(0.0f, 0.0f, 0.0f);

        original_main_camera_position = new Vector3(0.0f, 0.0f, 0.0f);
        original_parent_camera_position = new Vector3(0.0f, 0.0f, 0.0f);
        
       // parent_camera.transform.Rotate(90, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(main_camera.transform.localEulerAngles.x);
        //toggle position
        // parent camera position is the opposite of main_camera position
        if (Input.GetKeyDown("p"))
        {
            if (position_enable == true)
            {
                position_enable = false;
            }
            else
            {
                position_enable = true;
            }
            
        }
        //toggle rotation
        // parent camera position is the opposite of main_camera position
        if (Input.GetKeyDown("r"))
        {
            if (rotation_enable == true)
            {
                rotation_enable = false;
            }
            else
            {
                rotation_enable = true;
            }
        }

        if (position_enable == false)
        {
            //based on the distance main_camera moves, it would subtract the position of parent_camera to set main_camera to (0,0,0)

            distance_move = original_position - main_camera.transform.position;
            //the_camera.transform.position = original_position;
            parent_camera.transform.position += distance_move; //calculate the offset 
        }
        if (rotation_enable == false)
        {
            //Quaternion rotationX = Quaternion.AngleAxis(main_camera.transform.eulerAngles.x, new Vector3(-1f, 0f, 0f)); // -1 for opposite direction of rotation

            //Quaternion rotationY = Quaternion.AngleAxis(main_camera.transform.eulerAngles.y, new Vector3(0f, -1f, 0f));

           // Quaternion rotationZ = Quaternion.AngleAxis(main_camera.transform.eulerAngles.z, new Vector3(0f, 0f, -1f));


            //before rotation, need to store main_camera position because when we rotate the parent camera, the position of main camera will change.
            original_main_camera_position = main_camera.transform.position;
            parent_camera.transform.Rotate(-main_camera.transform.eulerAngles.x, -main_camera.transform.eulerAngles.y +180f, -main_camera.transform.eulerAngles.z);
           // parent_camera.transform.rotation = rotationX * rotationY * rotationZ ;
            parent_camera.transform.position =  original_main_camera_position - main_camera.transform.position;
            //rotation_move = original_rotation - main_camera.transform.localEulerAngles;
            //parent_camera.transform.Rotate(-rotation_move);
            //Debug.Log(main_camera.transform.localEulerAngles);


        }




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
