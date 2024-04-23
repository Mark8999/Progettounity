using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonControls : MonoBehaviour
{
    private UIManager uiManager;
    public GameObject Canvas;

    private void Awake()
    {
        uiManager = Canvas.GetComponent<UIManager>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
    }

    public void Pause()
    {
        uiManager.Pause();
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        uiManager.PauseScreen.SetActive(false);
      
    }

    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void QuitTheGame()
    {
        Application.Quit();
    }
}

