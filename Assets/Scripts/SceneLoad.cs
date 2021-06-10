using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    private bool gameIsPause = false;

    [SerializeField] private GameObject _pauseMenuUi;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Resume()
    {
        _pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        gameIsPause = false;
    }

    public void Pause()
    {
        _pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        gameIsPause = true;
    }
    public void ChangeScenes(int numScenes)
    {
        Time.timeScale = 1f;
        gameIsPause = false;
        SceneManager.LoadScene(numScenes);
    }

    public void ExitApp()
    {
        Application.Quit();
    }
}