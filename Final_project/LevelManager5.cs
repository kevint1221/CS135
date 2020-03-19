using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager5 : MonoBehaviour
{
    [Header("UI")]
    public Text nextLevelText;
    public Text restartText;
    public float sceneDelay = 3f;
    public float resetDelay = 5f;

    [Header("Visuals")]
    public float rotationSpeed = 1f;

    private GroundPlayerVR player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<GroundPlayerVR>();
        restartText.text = "";
        nextLevelText.text = "Level 5 \n Last wave!";
    }

    // Update is called once per frame
    void Update()
    {
        nextLevelText.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);

        // Check if player is killed
        if (player.Killed == true)
        {
            // Player killed, level failed, restart level 1
            StartCoroutine(ResetLevelDelay());
        }
        // Check if any ammo crate is left
        else if (GameObject.Find("AmmoCrate") == null)
        // No ammo crate left, check if any enemy is left
        {
            if (GameObject.Find("ShootingEnemy") == null)
            {
                // No enemy left, goes to next level
                StartCoroutine(MenuDelay());
            }
            // Check if player has enough ammo to kill the enemies left
            else if (player.Ammo <= 0)
            // Not enough ammo to kill remaining enemies, level failed, restart level 1
            {
                StartCoroutine(ResetLevelDelay());
            }
        }
        // Ammo crate left, check if any enemy is left
        else if (GameObject.Find("ShootingEnemy") == null)
        {
            // No enemy left, goes to next level
            StartCoroutine(MenuDelay());
        }
    }
    IEnumerator ResetLevelDelay()
    {
        // Load level 1 after 3 seconds
        restartText.text = "GG! \n Going back to menu in 3.2.1...";
        nextLevelText.text = "";
        restartText.transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
        yield return new WaitForSeconds(resetDelay);
        SceneManager.LoadScene("menu_room");
    }

    IEnumerator MenuDelay()
    {
        // Load level 5 after 3 seconds
        nextLevelText.text = "Winner winner \n chicken dinner! \n Back to menu in 3.2.1...";
        yield return new WaitForSeconds(sceneDelay);
        SceneManager.LoadScene("menu_room");
    }
}
