using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;
    public GameObject LaserGun;
    public GameObject LaserRifleSpread;
    public GameObject UImanager;
    private UIManager uimanager;
    public Text MyLife;
    public static int LifeNum;
    public GameObject Player;
    public Score score;


    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Score>();
        LifeNum = 10;
        health = maxHealth;
        uimanager = UImanager.GetComponent<UIManager>();
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        LifeNum -= 1;
        if (health <= 0)
        {
            uimanager.GameOver();
            Destroy(gameObject);
            

        }
      
    }
    
    // Update is called once per frame
    void Update()
    {
        MyLife.text = "Armor plate : " + LifeNum;
        if (score.ScoreNum >= 300)
        {
            LaserGun.SetActive(false);
            LaserRifleSpread.SetActive(true);
        }
    }
    
}
