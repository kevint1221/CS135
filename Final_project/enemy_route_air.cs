using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_route_air : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy_route_point;

    int route_state;
    void Start()
    {
        route_state = 0;
    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider other)  //something go pass the is trigger object
    {


        //make sure to add rigidbody component first
        switch (route_state)
        {
            case 0:
                enemy_route_point.transform.position = new Vector3(110f, 61f, 480f);
                route_state = 1;
                break;
            case 1:
                enemy_route_point.transform.position = new Vector3(149f, 113f, 461f);
                route_state = 2;
                break;
            case 2:
                enemy_route_point.transform.position = new Vector3(235f, 113f, 468f);
                route_state = 3;
                break;
            case 3:
                enemy_route_point.transform.position = new Vector3(294f, 34f, 379f);
                route_state = 4;
                break;
            case 4:
                enemy_route_point.transform.position = new Vector3(372f, 66f, 210f);
                route_state = 5;
                break;
            case 5:
                enemy_route_point.transform.position = new Vector3(268f, 74f, 173f);
                route_state = 0;
                break;
            default:
                break;
        }

    }

}
