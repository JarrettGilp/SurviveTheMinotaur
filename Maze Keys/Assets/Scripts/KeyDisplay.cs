using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyDisplay : MonoBehaviour
{
    public GameController controller;
    [SerializeField] GameObject key1, key2, key3, key4, key5, key6, key7;
    public int keyAmount;
    public TMP_Text keyText;

    
    // Update is called once per frame
    void Update()
    {
        keyAmount = controller.getKeyAmount();
        keyText.text = "Keys: " + keyAmount;

        switch(keyAmount)
        {
            case 7:
                key7.SetActive(true);
                break;
            case 6:
                key6.SetActive(true);
                break;
            case 5:
                key5.SetActive(true);
                break;
            case 4:
                key4.SetActive(true);
                break;
            case 3:
                key3.SetActive(true);
                break;
            case 2:
                key2.SetActive(true);
                break;
            case 1:
                key1.SetActive(true);
                break;
            default:
                break;
        }

    }
}
