using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HealthDisplay : MonoBehaviour
{
    public PlayerController player;
    public int playerHealth;
    public TMP_Text healthText;

    void Update()
    {
        playerHealth = player.getHealth();
        healthText.text = "Health: " + playerHealth;
    }
}
