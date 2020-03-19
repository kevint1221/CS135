using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    // the enemy you wanna response
    public GameObject lv1_minion;
    public GameObject lv1_cannon;
    public GameObject lv2_minion;
    public GameObject lv2_cannon; //red big aircraft
    public GameObject lv3_minion;
    public GameObject lv3_cannon; //sheep
    public GameObject lv4_minion;//sheep
    public GameObject boss;
    //            ///////////////////////////////

    float response_time; //time to response an enemy
    float delta; //time
    int number_enemy; //
    bool boss_response;
    // Start is called before the first frame update
    void Start()
    {
        response_time = 5f;
        delta = 0;
        number_enemy = 0;   //maximu number of minion
        boss_response = true; //response boss

    }

    // Update is called once per frame
    void Update()
    {
        switch(global_variable.enemy_kill)
        {
            case 4: 
                global_variable.level = 2;
                break;
            case 9:
                global_variable.level = 3;
                break;
            case 16:
                global_variable.level = 4;
                break;
            default:
                break;
        }

        this.delta += Time.deltaTime; 

        if (delta > response_time)  //response an enemy
        {
            delta = 0;
            if (global_variable.level == 1)    //level 
            {
                
                if (number_enemy == 3) //response cannon response 1
                {
                    //sponse cannnon
                    GameObject enemy = Instantiate(lv1_cannon) as GameObject;   //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;
                    Debug.Log("lv1cannon");

                }
                
                else if (number_enemy < 3) //resonse minion 3
                {
                    GameObject enemy = Instantiate(lv1_minion) as GameObject; //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;
                    Debug.Log("lv1minnion");
                }
                
            }
            else if (global_variable.level == 2)
            {
                if (number_enemy == 9) //sponse 1
                {
                    //sponse cannnon
                    GameObject enemy = Instantiate(lv2_cannon) as GameObject; //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;
                    Debug.Log("lv2cannon");

                }
                else if (number_enemy < 9) //sponse 4
                {
                    GameObject enemy = Instantiate(lv2_minion) as GameObject; //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;
                    Debug.Log("lv2minnion");
                }

            }
            else if (global_variable.level == 3)
            {
                if (number_enemy == 16) // response 1
                {
                    //sponse cannnon
                    GameObject enemy = Instantiate(lv3_cannon) as GameObject; //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;

                }
                else if (number_enemy < 16) // response 6
                {
                    GameObject enemy = Instantiate(lv3_minion) as GameObject; //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;
                }

            }

            else if (global_variable.level == 4)
            {
                if (boss_response == true)
                {
                    Debug.Log("boss out");
                    //sponse cannnon
                    GameObject enemy = Instantiate(boss) as GameObject; //use as GameOjbect to convert object to gameobject
                    //float x = Random.Range(-200, 200); //this is the x range of terrian
                   // float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(137,65,215); //enemy response position
                    boss_response = false; //boss only response once

                }
                else if  (number_enemy < 19) // response 6
                {
                    
                    //lv4_minion response every 5 second
                    GameObject enemy = Instantiate(lv4_minion) as GameObject; //use as GameOjbect to convert object to gameobject
                    float x = Random.Range(-200, 200); //this is the x range of terrian
                    float z = Random.Range(-200, 200); //this is the y range of terrian
                    enemy.transform.position = new Vector3(x, 200, z); //enemy response position
                    number_enemy++;

                }

            }

        }

    }
}
