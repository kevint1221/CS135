using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class global_variable : MonoBehaviour
{
   // Start is called before the first frame update
    public static int score;
    public static int reset_timer;
    public Text scorebox;
 
    void Start()
    {
        score = 0;
        reset_timer = 0;

        
    }

    // Update is called once per frame
    void Update()
    {
        scorebox.text = score.ToString();
        
        
    }
}
