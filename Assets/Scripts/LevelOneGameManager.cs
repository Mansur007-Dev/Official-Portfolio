using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelOneGameManager : MonoBehaviour
{
    public GameObject settingsPage; // Reference to the settings page GameObject
    private bool isPaused = false;





    void Start()
    {
        // Ensure settings page is initially inactive
        settingsPage.SetActive(false);
    }

    void Update()
    {
        // Check for spacebar press
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (settingsPage.activeSelf)
            {
                CloseSettingsPage();
            }
            else
            {
                OpenSettingsPage();
            }
        }
    }

    void OpenSettingsPage()
    {
        // Activate settings page and pause the game
        settingsPage.SetActive(true);

        PauseGame();
    }

    void CloseSettingsPage()
    {
        // Deactivate settings page and unpause the game
        settingsPage.SetActive(false);
        UnpauseGame();
    }

    void PauseGame()
    {
        if (!isPaused)
        {
            Time.timeScale = 0f; // Freeze time
            isPaused = true;
        }
    }

    void UnpauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1f; // Resume time
            isPaused = false;
        }
    }

    public void RestartTheWholeGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }





}
