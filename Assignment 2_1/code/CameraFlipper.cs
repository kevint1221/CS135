using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine.SceneManagement;

public class CameraFlipper : MonoBehaviour
{
    public GameObject parent_camera;
    // Start is called before the first frame update
    int x1;
    void Start()
    {
        x1 = 1;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown("f"))
        //if(OVRInput.GetDown(OVRInput.Button.One))
        //if(x1 == 1)
        {
            //rotate paren_camera 180 to y cordinate
            parent_camera.transform.Rotate(0f, 180f, 0f);
            x1 = 0;
        }
        

    }
}
