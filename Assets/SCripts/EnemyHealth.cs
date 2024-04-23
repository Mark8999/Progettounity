using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject Enemy;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
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
        score.ScoreNum += 100;
        if (Enemy.IsDestroyed())
        {
            
            print(score.ScoreNum);
        }
    }
}
