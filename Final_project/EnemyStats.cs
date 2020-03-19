using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Enemy_Level // Options for the engine audio
{
    level1_minion, // 
    level1_Cannon,// 
    level2_minion, // normal ship
    level2_cannon, //bigger one
    level3_cannon, //sheep
    boss,          //cow

}

public class EnemyStats : MonoBehaviour
{
    public float damage =0;
    public float attack_speed = 0;
    public float attack_range = 0;
    public float player_range = 0;
    public float health = 0;
    public float bullet_speed = 0;
    public float plane_size = 0;
    public Enemy_Level enemy_lv = Enemy_Level.level1_minion;// Set the default audio options to be four channel

    // Start is called before the first frame update
    void Awake() //awake runs before start()
    {
        switch (enemy_lv)
        {
            case Enemy_Level.level1_minion:
                health = 10;
                break;
            case Enemy_Level.level1_Cannon:
                health = 20f;
                damage = 10f;
                attack_speed = 3f;
                attack_range = 20f;
                player_range = 40f;
                bullet_speed = 0.6f;
                plane_size = 0.7f; //0.5 default
                
                break;
            case Enemy_Level.level2_minion:
                health = 30f;
                damage = 15f;
                attack_speed = 2f;
                attack_range = 30f;
                player_range = 30f;
                break;
            case Enemy_Level.level2_cannon:
                health = 50f;
                damage = 20f;
                attack_speed = 3f; //default is 3
                attack_range = 40f;
                player_range = 300f;
                bullet_speed = 0.6f;
                plane_size = 0.9f; //0.5 default
                break;
            case Enemy_Level.level3_cannon:
                health = 30f;
                damage = 20f;
                attack_speed = 3f; //default is 3
                attack_range = 40f;
                player_range = 200f;
                bullet_speed = 0.6f;
                plane_size = 0.5f; //0.5 default
                break;
            case Enemy_Level.boss:
                health = 100f;
                damage = 10f;
                attack_speed = 2f; //default is 3
                attack_range = 40f;
                player_range = 400f;
                bullet_speed = 1.5f;
                plane_size = 0.8f; //0.5 default
                break;
            default:
                break;

        }

        // Update is called once per frame
    }
}
