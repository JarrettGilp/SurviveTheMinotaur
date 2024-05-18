using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public static bool gameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameOver gameOver;
    public Win win;
    public bool mapOn;
    public bool paused;
    public Pause pauseObj;

    private void Start()
    {
        mapOn = false;
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (mapOn)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            pauseObj.setCanPause(false);
        }

    }

   

    public void Resume()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        pauseObj.setPaused(false);
    }
    public void Pause()
    {
        pauseObj.setPaused(true);
     }

    public void LoadMenu()
    {
        paused = false;
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);        
    }

    public void DeathPause()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void MapPause()
    {
        mapOn = true;
    }

    public void MapResume()
    {
        mapOn = false;

        pauseObj.setCanPause(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game.");
        Application.Quit();
    }

}
