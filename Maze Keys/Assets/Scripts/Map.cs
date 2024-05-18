using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    GameObject playerCamera;
    GameObject mapCamera;
    [SerializeField] GameObject roof;
    [SerializeField] GameObject mapPlayer;
    public bool mapOn;
    public bool canMap;
    public PauseMenu pauseMenu;
    public GameObject minotaur;

    private void Start()
    {
        playerCamera = GameObject.FindGameObjectWithTag("MainCamera");
        mapCamera = GameObject.FindGameObjectWithTag("MapCamera");
        mapOn = false;
        canMap = true;
    }

    // Update is called once per frame
    void Update()
    {
        if ( getCanMap() )
        {

            if (Input.GetKeyDown(KeyCode.M))
            {
                mapOn = !mapOn;
            }

            if (mapOn == true)
            {
                pauseMenu.MapPause();
                minotaur.SetActive(false);
                roof.SetActive(true);
                mapPlayer.SetActive(true);
                playerCamera.SetActive(false);
                mapCamera.SetActive(true);
            }

            if (mapOn == false)
            {
                pauseMenu.MapResume();
                minotaur.SetActive(true);
                roof.SetActive(false);
                mapPlayer.SetActive(false);
                mapCamera.SetActive(false);
                playerCamera.SetActive(true);
            }
        }
    }

    public void setCanMap(bool canMap)
    {
        this.canMap = canMap;
    }

    public bool getCanMap()
    {
        return canMap;
    }

}
