using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MinotaurMove : MonoBehaviour
{

    public GameController controller;
    GameObject player;
    NavMeshAgent minotaur;
    float currentSpeed;
    int keyAmount;

    // Start is called before the first frame update
    void Start()
    {
        currentSpeed = 5f;
        minotaur = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        minotaur.SetDestination(player.transform.position);
        keyAmount = controller.getKeyAmount();

        // SPEED OF MINOTAUR BASED OFF KEY AMOUNT AND PROXIMITY
        if (keyAmount == 0 || keyAmount == 1 || keyAmount == 2) { 
            minotaur.GetComponent<NavMeshAgent>().speed = 5f;
            setCurrentSpeed(5f);
        }
        else if (keyAmount == 3 || keyAmount == 4) {
            minotaur.GetComponent<NavMeshAgent>().speed = 10f;
            setCurrentSpeed(10f);
        }
        else if (keyAmount == 5 || keyAmount == 6) { 
            minotaur.GetComponent<NavMeshAgent>().speed = 15f;
            setCurrentSpeed(15f);
        }
        else { 
            minotaur.GetComponent<NavMeshAgent>().speed = 20f;
            setCurrentSpeed(20f);
        }

    }

    void setCurrentSpeed(float currentSpeed)
    {
        minotaur.GetComponent<NavMeshAgent>().speed = currentSpeed;
        this.currentSpeed = currentSpeed;
    }

    public void increaseMinotaurSpeed()
    {
        setCurrentSpeed(30f);
    }

    public float getCurrentSpeed()
    {
        return currentSpeed;
    }

    public void backToDefaultMinotaurSpeed()
    {
        float minoCurrSpeed = getCurrentSpeed();
        setCurrentSpeed(minoCurrSpeed);
    }
}
