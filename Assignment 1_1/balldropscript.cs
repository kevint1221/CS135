using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balldropscript : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject ball; 
    void OnTriggerEnter(Collider other)  //something go pass the is trigger object
    {

        //make sure to add rigidbody component first
        ball.GetComponent<Rigidbody>().useGravity = true;   //set use gravity to true

    }

    

}
