using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject LaserGun;
    public GameObject LaserRifleSpread;
    public GameObject UImanager;
    private UIManager uimanager;

   
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        uimanager = UImanager.GetComponent<UIManager>();
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            uimanager.GameOver();
            Destroy(gameObject);
            

        }
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Score.ScoreNum >= 400)
        {
            LaserGun.SetActive(false);
            LaserRifleSpread.SetActive(true);
        }
    }
    
}
