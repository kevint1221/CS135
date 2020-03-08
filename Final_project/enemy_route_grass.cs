using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_route_grass : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy_route_point;
    public GameObject player;

    int route_state;
    void Start()
    {
        route_state = 0;
        //enemy_route_point.transform.position = player.transform.position + new Vector3(30f, 0f, 0f);
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
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(50f, 0, 0)); ;
                route_state = 1;
                Debug.Log("p1");
                break;
            case 1:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(25f, 25, 0f));
                route_state = 2;
                break;
            case 2:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(0f, 50f, 0f));
                route_state = 3;
                Debug.Log("p2");
                break;
            case 3:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(-25f, 25, 0f));
                route_state = 4;
                break;
            case 4:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(-50f, 0f, 0f));
                route_state = 5;
                break;
            case 5:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(-25f, -25f, 0f));
                route_state = 6;
                break;
            case 6:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(0f, -50, 0f));
                route_state = 7;
                break;
            case 7:
                enemy_route_point.transform.position = player.transform.position + player.transform.TransformDirection(new Vector3(25f, -25, 0f));
                route_state = 0;
                break;

            default:
                break;
        }

    }

}
