using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinotaurAttack : MonoBehaviour
{
    GameObject minotaur;
    BoxCollider axeCollider;
    Animator minotaurAnimator;
    AudioSource minoAttackAudioSource;
    float coolDownTime;

    private IEnumerator AxeWait(float coolDown)
    {
        yield return new WaitForSeconds(coolDown);
        axeCollider.enabled = !axeCollider.enabled;
    }

    private void Start()
    {
        minotaur = GameObject.FindGameObjectWithTag("Minotaur");
        axeCollider = GameObject.FindGameObjectWithTag("Axe").GetComponent<BoxCollider>();
        minotaurAnimator = minotaur.GetComponent<Animator>();
        minoAttackAudioSource = GameObject.FindWithTag("AttackAudio").GetComponent<AudioSource>();
        coolDownTime = 2f;
    }

    private void OnTriggerEnter(Collider other)
    {
        axeCollider.enabled = !axeCollider.enabled;

        if (axeCollider.enabled) {

            minotaurAnimator.Play("attack3");
            minoAttackAudioSource.Play();
            StartCoroutine(AxeWait(coolDownTime));

        }

    }

}
