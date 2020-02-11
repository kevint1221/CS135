using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirroring : MonoBehaviour
{
    public GameObject the_camera; //main camera
    public GameObject head; //the head
    Vector3 distance_different;
    Vector3 camera_original;
    Vector3 head_original;
    
    int x1; //testing on mac
    
    

    public int mode;

    // Start is called before the first frame update
    void Start()
    {
        mode = 0;
        //x1 = 0; //testing on mac
        //StartCoroutine(ExampleCoroutine()); //testing on mac

        
       
    }

    //this function is used to use the function after certain seconds
    IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(5);

        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
        mode = 1;
        x1 = 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        //if (x1 == 1) //testing on mac
        {
            //mode 0: original
            //mode 1: same movement
            //mode 2: mirror movement

            if (mode == 0) 
            {
                //set mdoe to same movement
                mode = 1;
                //find the original position different between the head and the main camera
                distance_different = the_camera.transform.position - head.transform.position;


            }
            else if (mode == 1)
            {
                //mirror movement
                //distance_different = head.transform.position - the_camera.transform.position;
                head_original = head.transform.position;
                camera_original = the_camera.transform.position;
                
               
                mode = 2;
                //x1 = 0; //testing on mac
                
            }
            else if (mode == 2)
            {
                //nothing move
                mode = 1;
            }
        }

        switch(mode)
        {
            case 0:
                break;
            case 1:

                //set sync the head rotation with main camera rotation 
                head.transform.rotation = the_camera.transform.rotation;
                head.transform.Rotate(0.0f, -90.0f, 0.0f);

                //fixed the psotion difference between camera and head
                head.transform.position = the_camera.transform.position - distance_different;
                break;
            case 2:
                //rotation
                //float x = the_camera.transform.rotation.x; 


                //Vector3 temp = transform.localScale;
                //temp.x = the_camera.transform.localScale.x * -1;
                //head.transform.localScale = temp;

                //Vector3 rotate_x = transform.eulerAngles;
                //rotate_x.x = the_camera.transform.eulerAngles * -1;
                //the_camera

                //head.transform.rotation = the_camera.transform.rotation;

                //head.transform.rotation = Quaternion.Inverse(the_camera.transform.rotation);

                //head.transform.rotation = Quaternion.Euler(the_camera.transform.rotation.x, the_camera.transform.rotation.y, the_camera.transform.rotation.z);

                //find camera rotation 
                Quaternion rotationX = Quaternion.AngleAxis(the_camera.transform.eulerAngles.x, new Vector3(-1f, 0f, 0f)); // -1 for opposite direction of rotation

                Quaternion rotationY = Quaternion.AngleAxis(the_camera.transform.eulerAngles.y, new Vector3(0f, -1f, 0f));

                Quaternion rotationZ = Quaternion.AngleAxis(the_camera.transform.eulerAngles.z, new Vector3(0f, 0f, 1f));

                head.transform.rotation = rotationX * rotationY * rotationZ; //function to calcualte quaternion


                head.transform.Rotate(0f, 90f, 0f); //fixed the head rotation
               



                //head.transform.rotation = new Quaternion(x, y, z, w);

                //head.transform.localEulerAngles = new Vector3(the_camera.transform.localEulerAngles.x, -the_camera.transform.localEulerAngles.y, -the_camera.transform.localEulerAngles.z);


                //position
                Vector3 camera_different = camera_original- the_camera.transform.position;
                Vector3 camera_position = the_camera.transform.position;
                camera_original = the_camera.transform.position;
                head.transform.position = new Vector3(head_original.x, head_original.y, head_original.z);
                head.transform.position += new Vector3(0f,0f, camera_different.z); //the z movement is same as camera, just like mirror
                head_original = head.transform.position;


                break;
            default:
                break;

        }


    }
}
