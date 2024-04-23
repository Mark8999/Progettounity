using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Winning : MonoBehaviour
{
    public Text YouWin; // Insert your text object inside unity inspector

    void Start()
    {
        YouWin.enabled = false; // You may need to use .SetActive(false);
    }


    // Assuming you're using a 2D platform
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            // This is where you make your text object appear on screen
            YouWin.enabled = true; // May need to use .SetActive(true);
        }
    }
}
