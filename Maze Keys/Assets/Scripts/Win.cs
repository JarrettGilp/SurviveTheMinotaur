using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameController controller;
    public bool gameWon;

    void Start()
    {
        gameWon = false;
    }

    public bool getWinState()
    {
        return gameWon;
    }

    private void Update()
    {
        if( gameWon )
        {
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    //private void OnTriggerStay(Collider collider)
    private void OnTriggerEnter(Collider collider)
    {
        if( controller.getKeyAmount() >= 7 )
        {
            gameWon = true;
        }
    }

}
