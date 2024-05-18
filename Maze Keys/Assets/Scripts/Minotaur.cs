using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minotaur : MonoBehaviour
{
    public PlayerController player;
    private bool canHurtPlayer;
    private float coolDown;

    public AudioSource minoRandAudioSource;
    public AudioClip[] randAudioClips;

    public CapsuleCollider minotaurCollider;

    private IEnumerator TouchCoolDown(float time)
    {
        yield return new WaitForSeconds(time);
        minotaurCollider.enabled = !minotaurCollider.enabled;
        yield return new WaitForSeconds(0.1f);
        minotaurCollider.enabled = !minotaurCollider.enabled;
        canHurtPlayer = !canHurtPlayer;
    }

    private IEnumerator PlayRandAudio()
    {
        while(true)
        {
            yield return new WaitForSeconds(8f);
            minoRandAudioSource.clip = randAudioClips[Random.Range(0, randAudioClips.Length)];
            minoRandAudioSource.Play();
        }

    }

    void Start()
    {
        canHurtPlayer = true;
        coolDown = 1f;
        StartCoroutine(PlayRandAudio());
    }

    private void OnCollisionStay(Collision collision)
    {
        if( canHurtPlayer )
        {
            canHurtPlayer = !canHurtPlayer;
            player.health -= 5;
            StartCoroutine(TouchCoolDown(coolDown));
        }

    }

}
