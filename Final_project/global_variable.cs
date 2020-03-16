using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class global_variable : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool hit_sound_enable;
    public static bool under_attack;
    public static bool pause_game;
    public static int enemy_kill;
    public static bool goat_scream;
    public static bool hit_goat;
    public static int level;
    public GameObject sheep;
    public static bool hit_terrain;
    void Start()
    {
        hit_sound_enable = false;
        pause_game = false;
        enemy_kill = 3;
        goat_scream = false;
        hit_goat = false;
        level = 1;
        under_attack = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if(enemy_kill == 4) //level3
        //{
          //  sheep.SetActive(true);
        //}
        
    }
}
