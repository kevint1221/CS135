using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Event : MonoBehaviour
{
    public GameObject aircraft;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)  //something go pass the is trigger object
    {

        //make sure to add rigidbody component first
        aircraft.transform.position = new Vector3(3.9f, 5f, -5f);

    }
}
