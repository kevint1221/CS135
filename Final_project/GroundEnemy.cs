﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : MonoBehaviour
{
    public int health = 5;
    public int damage = 5;

    private bool killed = false;
    public bool Killed { get { return killed; } }

    void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.GetComponent<GroundBullet>() != null)
        {
            GroundBullet bullet = otherCollider.GetComponent<GroundBullet>();
            if (bullet.ShotByPlayer == true)
            {
                health -= bullet.damage;
                bullet.gameObject.SetActive(false);
                if (health <= 0)
                {
                    if (killed == false)
                    {
                        killed = true;
                        OnKill();
                    }
                }
            }
        }
    }

    protected virtual void OnKill() 
    {
        Destroy(gameObject, 5);
    }
}