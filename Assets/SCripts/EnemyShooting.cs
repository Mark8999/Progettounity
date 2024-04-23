using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    //public float shotCounter, fireRate;
    //public float fireRate;
    public float shotSpeed;
    public Transform firePoint;
    public GameObject ammoType;
    public float attackCooldown;
    public float cooldownTimer = Mathf.Infinity;
   
    
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            cooldownTimer += Time.deltaTime;
            //shotCounter -= Time.deltaTime;
            if (cooldownTimer >= attackCooldown) 
            {
                cooldownTimer = 0;
                //shotCounter = fireRate;
                Shoot();
            }
            
        }
    }
    void Shoot() //instantiate Prefab
    {
        int enemyDir()
        {
            if (transform.parent.localScale.x < 0f)
            {
                return -1;
            }
            else
            {
                return +1;
            }
        }
        GameObject shot = Instantiate(ammoType, firePoint.position, firePoint.rotation);
        Rigidbody2D shotRB = shot.GetComponent<Rigidbody2D>();
        shotRB.AddForce(firePoint.right * shotSpeed * enemyDir(), ForceMode2D.Impulse);
        Destroy(shot.gameObject, 1f);
    }
}

