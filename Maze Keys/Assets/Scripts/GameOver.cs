using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public PlayerController player;
    bool isDead;

    private void Start()
    {
        isDead = false;
    }

    private void Update()
    {
        if (player.getHealth() <= 0)
        {
            isDead = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

    }

    public bool getDeathState()
    {
        return isDead;
    }

}
