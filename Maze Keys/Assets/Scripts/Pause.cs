using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public PauseMenu pauseMenu;
    public GameObject pauseMenuUI;
    public Map map;
    public bool paused;
    public bool canPause;

    private void Start()
    {
        canPause = true;
        paused = false;
    }

    private void Update()
    {
        if( getCanPause() )
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                setPaused(!paused);
            }

            if (getPaused())
            {
                map.setCanMap(false);
                pauseMenuUI.SetActive(true);
                PauseTime();
            }
            else
            {
                map.setCanMap(true);
                pauseMenuUI.SetActive(false);
                pauseMenu.Resume();
            }
        }
        
    }

    public void setCanPause(bool canPause)
    {
        this.canPause = canPause;
    }

    public bool getCanPause()
    {
        return canPause;
    }

    public void setPaused(bool paused)
    {
        this.paused = paused;
    }

    public bool getPaused()
    {
        return paused;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
        setPaused(false);
    }

    public void PauseTime()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        setPaused(true);
    }
}
