using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage;

     
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
           EnemyHealth enemyHealth = collision.gameObject.GetComponent<EnemyHealth>(); 
           enemyHealth.TakeDamage(damage);
           Destroy(gameObject);
        }
        if (collision.CompareTag("Player"))
        {
            PlayerHealth playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            playerHealth.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}
