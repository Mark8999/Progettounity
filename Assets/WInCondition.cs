using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Text pointsText;
    public void Setup(int score)
    {
        gameObject.SetActive(true);

    }
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
