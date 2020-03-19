using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCanvas : MonoBehaviour
{
    [Header("Visuals")]
    public float rotationSpeed = 90f;
    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        canvas.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
