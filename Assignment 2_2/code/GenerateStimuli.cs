using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStimuli : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject red;
    public GameObject blue1;
    public GameObject blue2;
    public GameObject main_camera;
    //public GameObject parent_camera;
    Vector3 original_position = new Vector3(0.0f, 0.0f, 0.0f);
    float distance_red = 0;
    float distance_blue1 = 0;
    float distance_blue2 = 0;
    Vector3 red_position = new Vector3(0f, 0f, -2.3f);
    Vector3 blue1_position = new Vector3(0.7f, 0f, -1.6f);
    Vector3 blue2_position = new Vector3(-0.8f, 0f, -1f);
    float size_blue1 = 0;
    float size_blue2 = 0;

    //setActive
    bool start_counting = false; //enable counting
    float timer = 0;
    bool enable_generateStimuli = false;

    void Start()
    {
        //Debug.Log("hello");
        start_counting = false;
        timer = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //store the size of red sphere
        //we first find the ratio of the size
        //change size
        //red.transform.localScale = new Vector3(5f, 5f, 5f);
        if (enable_generateStimuli)
        {
            distance_red = Vector3.Distance(main_camera.transform.position, red_position);
            distance_blue1 = Vector3.Distance(main_camera.transform.position, blue1_position);
            distance_blue2 = Vector3.Distance(main_camera.transform.position, blue2_position);

            size_blue1 = distance_blue1 * red.transform.localScale.x / distance_red;
            blue1.transform.localScale = new Vector3(size_blue1, size_blue1, size_blue1);
            size_blue2 = distance_blue2 * red.transform.localScale.x / distance_red;
            blue2.transform.localScale = new Vector3(size_blue2, size_blue2, size_blue2);
        }


        //setActive
        if (start_counting == true)
        {
            //turning blue1,2 off after 2 seconds
            timer = timer - Time.deltaTime;
            if (timer <= 0) //need to be <= 0 because it is a float and update call each frame
            {
                if (blue1.activeSelf == true)
                {
                    blue1.SetActive(false);
                    blue2.SetActive(false);
                }
                else
                {
                    blue1.SetActive(true);
                    blue2.SetActive(true);
                }
                timer = 2;
                start_counting = false;
            }

        }


        //press s
        if (Input.GetKeyDown("s"))
        {
            enable_generateStimuli = true;
            if (red.activeSelf == true)
            {
                red.SetActive(false);
            }
            else
            {
                red.SetActive(true);
            }
            start_counting = true;

        }
    }
}
