﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPlayerVR : MonoBehaviour
{
    [Header("Visuals")]
    //public Camera playerCamera;
    public GameObject barrel;
    public GameObject barrelEnd;

    [Header("Gameplay")]
    public int initialAmmo = 15;
    public int initialHealth = 100;
    // public float knowbackForce = 10;
    public float hitDuration = 0.5f;

    public OVRInput.Button shootingButton;
    private OVRGrabbable ovrGrabbable;

    private int ammo;
    public int Ammo { get { return ammo; } }

    private int health;
    public int Health { get { return health; } }

    private bool killed;
    public bool Killed { get { return killed; } }

    public Animator shoot;
    private bool isHurt;

    // Start is called before the first frame update
    void Start()
    {
        ammo = initialAmmo;
        health = initialHealth;
        ovrGrabbable = GameObject.Find("Handgun").GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrabbable.isGrabbed == true)
        {
            if (OVRInput.GetDown(shootingButton, ovrGrabbable.grabbedBy.GetController()))
            {
                if (ammo > 0)
                {
                    ammo--;
                    shoot.GetComponent<Animator>().SetTrigger("Fire");
                    GameObject bulletObject = ObjectPoolingManager.Instance.GetBullet(true);
                    bulletObject.transform.position = barrel.transform.position;
                    bulletObject.transform.forward = (barrel.transform.position - barrelEnd.transform.position).normalized;
                }

            }
        }
    }

    // Check for collision
    void OnTriggerEnter(Collider othercollider)
    {
        // Collet ammo from ammo crates
        if (othercollider.GetComponent<AmmoCrate>() != null)
        {
            AmmoCrate ammoCrate = othercollider.GetComponent<AmmoCrate>();
            ammo += ammoCrate.ammo;
            Destroy(ammoCrate.gameObject);
        }
        // Collet health from health potions
        else if (othercollider.GetComponent<HealthPotion>() != null)
        {
            HealthPotion healthPotion = othercollider.GetComponent<HealthPotion>();
            health += healthPotion.health;
            Destroy(healthPotion.gameObject);
        }

        if (isHurt == false)
        {
            GameObject hazard = null;
            if (othercollider.GetComponent<GroundEnemy>() != null)
            {
                GroundEnemy enemy = othercollider.GetComponent<GroundEnemy>();
                if (enemy.Killed == false)
                {
                    hazard = enemy.gameObject;
                    health -= enemy.damage;
                }
            }
            else if (othercollider.GetComponent<GroundBullet>() != null)
            {
                GroundBullet bullet = othercollider.GetComponent<GroundBullet>();
                if (bullet.ShotByPlayer == false)
                {
                    if (bullet.ShotByPlayer == false)
                    {
                        hazard = bullet.gameObject;
                        health -= bullet.damage;
                        bullet.gameObject.SetActive(false);
                    }
                }
            }

            if (hazard != null)
            {
                isHurt = true;

                // perform knockback effect
                /*
                Vector3 hurtDirection = (transform.position - hazard.transform.position).normalized;
                Vector3 knockbackDirection = (hurtDirection + Vector3.up).normalized;
                GetComponent<ForceReceiver>().AddForce(knockbackDirection, knowbackForce);
                */
                StartCoroutine(HurtRoutine());
            }

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

    IEnumerator HurtRoutine()
    {
        yield return new WaitForSeconds(hitDuration);

        isHurt = false;
    }

    private void OnKill() { }
}
