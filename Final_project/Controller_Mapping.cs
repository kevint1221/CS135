using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Controller_Mapping : MonoBehaviour
{
    public GameObject aircraft;
    public GameObject front_end;
    public GameObject back_end;
    Vector3 offset;
    Vector2 left_stick;
    float hand_trigger;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
        offset = new Vector3(0f, 0f, 0f);

    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(OVRInput.Axis2D.SecondaryThumbstick);
        

        if (OVRInput.GetDown(OVRInput.RawButton.A))
        {
            Debug.Log("A");

        }
        
        if (OVRInput.GetDown(OVRInput.RawButton.B))
        {
            Debug.Log("B");

        }
        //if (OVRInput.GetDown(OVRInput.RawButton.X))
        
        //{
         //   Debug.Log("X");

       // }

        //reset the scene
        if (OVRInput.GetDown(OVRInput.RawButton.Y))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        //read left thumbstick
        left_stick = OVRInput.Get(OVRInput.RawAxis2D.LThumbstick);
        float scale = 3f;
        //left thumbstick up
        if (left_stick.y > 0.0f)
        {
            Debug.Log("right_stick move up");
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
            Debug.Log("right_stick move down");
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
            Debug.Log("right_stick move up");
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
            Debug.Log("right_stick move up");
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
        hand_trigger = OVRInput.Get(OVRInput.RawAxis1D.LHandTrigger);
        if (hand_trigger > 0f)
        {
            offset = front_end.transform.position - back_end.transform.position;
            if (hand_trigger <= 0.2)
            {
                aircraft.transform.position += 0.02f * offset;
               
            }
            else if (hand_trigger <= 0.4)
            {
                aircraft.transform.position += 0.03f * offset;
                
            }
            else if (hand_trigger <= 0.6)
            {
                aircraft.transform.position += 0.04f * offset;
                
            }
            else if (hand_trigger <= 0.8)
            {
                aircraft.transform.position += 0.05f * offset;
                
            }
            else
            {
                aircraft.transform.position += 0.06f * offset;
                

            }

            //offset = front_end.transform.position - back_end.transform.position;
            //aircraft.transform.position += offset;

        }
        else
        {
            //keeps going forward from inertia
        //    offset = front_end.transform.position - back_end.transform.position;
        //    aircraft.transform.position += 0.01f * offset;
            
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