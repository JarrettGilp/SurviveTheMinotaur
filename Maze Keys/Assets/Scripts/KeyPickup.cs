using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public PlayerController player;
    public GameController controller;
    private AudioSource keySoundEffect;

    private void Start()
    {
        keySoundEffect = GameObject.FindWithTag("KeySound").GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        keySoundEffect.Play();
        Destroy(gameObject);
        controller.increaseKeyAmount();
    }
}
