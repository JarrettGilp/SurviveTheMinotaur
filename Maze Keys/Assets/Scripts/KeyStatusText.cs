using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyStatusText : MonoBehaviour
{
    public GameController controller;
    public TMP_Text statusText;
    public int remainingKeys;

    // Update is called once per frame
    void Update()
    {
        remainingKeys = 7 - controller.getKeyAmount();
        statusText.text = remainingKeys + " Keys Left to Open Door";
    }
}
