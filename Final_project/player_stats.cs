using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_stats : MonoBehaviour
{
    // Start is called before the first frame update
    public static float player_health;
    public static float attack_speed;
    public static float damage;

    void Start()
    {
        player_health = 100f;
        attack_speed = 1f;
        damage = 10f;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
