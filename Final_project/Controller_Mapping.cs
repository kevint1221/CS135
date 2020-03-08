using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller_Mapping : MonoBehaviour
{
    public GameObject aircraft;
    public GameObject front_end;
    public GameObject back_end;
    public GameObject canvas;
    public GameObject pointer;

    public string health_script;// your second script name 

    Vector3 offset;
    Vector2 left_stick;
    float hand_trigger;
    float counter;
    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
        offset = new Vector3(0f, 0f, 0f);
        counter = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(OVRInput.Axis2D.SecondaryThumbstick);
        

        
        //if (OVRInput.GetDown(OVRInput.RawButton.A))
        //{
           // Debug.Log("A");

       // }
        
     //   if (OVRInput.GetDown(OVRInput.RawButton.B))
       // {
           // Debug.Log("B");

     //   }
        //if (OVRInput.GetDown(OVRInput.RawButton.X))
        
        //{
         //   Debug.Log("X");

       // }

        //reset the scene
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


        float keyboard_scale = 5f;
        float keyboard_forward_scale = 0.05f;
        Vector3 keyboard_offset  = front_end.transform.position - back_end.transform.position;
        /////keyboard control
        if (Input.GetKey("w"))
        {
            aircraft.transform.Rotate(-keyboard_scale / 10, 0f, 0f, Space.Self);
        }
        if (Input.GetKey("s"))
        {
            aircraft.transform.Rotate(keyboard_scale / 10, 0f, 0f, Space.Self);
        }
        if (Input.GetKey("a"))
        {
            aircraft.transform.Rotate(0f, -keyboard_scale / 10, 0f, Space.Self);
        }
        if (Input.GetKey("d"))
        {
            aircraft.transform.Rotate(0f, keyboard_scale / 10, 0f, Space.Self);
        }
        if (Input.GetKey("space"))
        {
            aircraft.transform.position += keyboard_forward_scale * 6 * keyboard_offset;
        }
        if (Input.GetKey("h"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }



        //read left thumbstick
        left_stick = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        float scale = 1f; //1 is default for normal people
        //left thumbstick up
        if (left_stick.y > 0.0f)
        {
            //Debug.Log("right_stick move up");
            if (left_stick.y <= 0.3)
            {
                aircraft.transform.Rotate(-scale/40f, 0f, 0f, Space.Self);
            }
            else if (left_stick.y <= 0.6)
            {
                aircraft.transform.Rotate(-scale/20, 0f, 0f, Space.Self);
            }
            else
            {
                aircraft.transform.Rotate(-scale/10, 0f, 0f, Space.Self);
            }
        }

        

            //Debug.Log(front_end.transform.position);

            //left thumbstick down
            if (left_stick.y < 0.0f)
        {
           // Debug.Log("right_stick move down");
            if (left_stick.y >= -0.3)
            {
                aircraft.transform.Rotate(scale/40, 0f, 0f, Space.Self);
            }
            else if (left_stick.y >= -0.6)
            {
                aircraft.transform.Rotate(scale/20, 0f, 0f, Space.Self);
            }
            else
            {
                aircraft.transform.Rotate(scale/10, 0f, 0f, Space.Self);
            }
        }

        //left thumbstick right
        if (left_stick.x > 0.0f)
        {
           // Debug.Log("right_stick move up");
            if (left_stick.x <= 0.3)
            {
                aircraft.transform.Rotate(0f, scale/40, 0f, Space.Self);
            }
            else if (left_stick.x <= 0.6)
            {
                aircraft.transform.Rotate(0f, scale /20, 0f, Space.Self);
            }
            else
            {
                aircraft.transform.Rotate(0f, scale /10, 0f, Space.Self);
            }
        }

        //left thumbstick left
        if (left_stick.x < 0.0f)
        {
            //Debug.Log("right_stick move up");
            if (left_stick.x >= -0.3)
            {
                aircraft.transform.Rotate(0f, -scale /40, 0f, Space.Self);
            }
            else if (left_stick.x >= -0.6)
            {
                aircraft.transform.Rotate(0f, -scale /20, 0f, Space.Self);
            }
            else
            {
                aircraft.transform.Rotate(0f, -scale /10, 0f, Space.Self);
            }
        }

        //going foward

        float forward_scale = 0.01f;  //0.01 is default
        hand_trigger = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);
        if (hand_trigger > 0f)
        {
            offset = front_end.transform.position - back_end.transform.position;
            if (hand_trigger <= 0.2)
            {
                aircraft.transform.position += forward_scale * 2 * offset;
               
            }
            else if (hand_trigger <= 0.4)
            {
                aircraft.transform.position += forward_scale * 3 * offset;
                
            }
            else if (hand_trigger <= 0.6)
            {
                aircraft.transform.position += forward_scale * 4 * offset;
                
            }
            else if (hand_trigger <= 0.8)
            {
                aircraft.transform.position += forward_scale * 5 * offset;
                
            }
            else
            {
                aircraft.transform.position += forward_scale * 6 * offset;
                

            }

            //offset = front_end.transform.position - back_end.transform.position;
            //aircraft.transform.position += offset;

        }
        else
        {
            //keeps going forward from inertia
           //// offset = front_end.transform.position - back_end.transform.position;
            //// aircraft.transform.position += 0.01f * offset;
            
        }

        //fix angle issue with Z axis
       // Debug.Log(aircraft.transform.eulerAngles.z);

        //player not moving left stick
        if(counter <= 0)
        {
            if (left_stick.x == 0f && left_stick.y == 0f)
            {
                //adjust z axis
                //if(360f - aircraft.transform.eulerAngles.z != 0f)
                //{
                float angle_offset = 360f - aircraft.transform.eulerAngles.z;
                if (Mathf.Abs(360f - aircraft.transform.eulerAngles.z) > 2)
                {
                    if (aircraft.transform.eulerAngles.z > 300) 
                    {
                        //counterclockwise
                        aircraft.transform.Rotate(0f, 0f, 0.01f * angle_offset);
                        
                    }
                    else
                    {
                        //clockwise
                        aircraft.transform.Rotate(0f, 0f, 0.0001f * -angle_offset); //not sure why clockwise is faster than counter clock
                    }
                    

                }

                //}
            }
            
        }
        counter -= Time.deltaTime;
       

        if(OVRInput.GetDown(OVRInput.RawButton.Start))
        {
            if (canvas.activeSelf == false)
            {
                canvas.SetActive(true);
                pointer.SetActive(true);
                Time.timeScale = 0.2f;
                (aircraft.GetComponent(health_script) as MonoBehaviour).enabled = false;
            }

            
               
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