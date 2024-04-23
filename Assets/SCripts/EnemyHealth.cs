using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnDestroy()
    {
        if (Enemy.IsDestroyed())
        {
            Score.ScoreNum += 100;
            print(Score.ScoreNum);
        }
    }
}
