using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject leftDoor, rightDoor;
    public int keyAmount;
    public bool doorsLocked;
    public GameObject doorUnlockUI;
    public GameObject doorOpenObj;
    private AudioSource doorOpenAudioSource;

    private IEnumerator ShowUnlockText()
    {
        doorUnlockUI.SetActive(true);
        doorOpenAudioSource.Play();
        yield return new WaitForSeconds(5f);
        doorUnlockUI.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        doorsLocked = true;
        keyAmount = 0;
        doorOpenAudioSource = doorOpenObj.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if( getKeyAmount() == 7 && doorsLocked)
        {
            Destroy(leftDoor);
            Destroy(rightDoor);
            doorsLocked = false;
            StartCoroutine(ShowUnlockText());
        }

    }

    public int getKeyAmount()
    {
        return keyAmount;
    }

    public void increaseKeyAmount()
    {
        keyAmount++;
    }
}
