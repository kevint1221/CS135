using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [Header("Game")]
    public GroundPlayerVR player;

    [Header("UI")]
    public Text ammoText;
    public Text healthText;

    private OVRGrabbable ovrGrabbable;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<GroundPlayerVR>();
        ovrGrabbable = GameObject.Find("Handgun").GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrabbable.isGrabbed == true)
        {
            ammoText.text = player.Ammo.ToString();
            healthText.text = player.Health.ToString();
        }
        else
        {
            ammoText.text = "";
            healthText.text = "";
        }
        // if (player.Killed == true){ }
    }
}
