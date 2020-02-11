using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class room_switch : MonoBehaviour
{
    Vector3 temp_position;
    // Start is called before the first frame update
    int room;
    void Start()
    {
        room = 1;

}

    // Update is called once per frame
    void Update()
    {

        temp_position = this.transform.position;
        if (Input.GetKeyDown("2"))
        {
            if(room == 1)
            {
                GetComponent<CharacterController>().enabled = false;
                room = 2;
                this.transform.position = new Vector3(60f, 1.8f, 0);
                GetComponent<CharacterController>().enabled = true;
            }
            
        }

        if (Input.GetKeyDown("1"))
        {
            if (room == 2)
            {
                GetComponent<CharacterController>().enabled = false;
                this.transform.position = new Vector3(0, 1.8f, 0);
                GetComponent<CharacterController>().enabled = true;
                room = 1;
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
