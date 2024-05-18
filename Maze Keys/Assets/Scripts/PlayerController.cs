using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    /*
    public float verticalInput;
    public float walkingSpeed = 10.0f;
    public float xSensitivity;
    public float ySensitivity;
    public float xRotation;
    public float yRotation;
    public Transform orientation;
    public int health = 10;
    */

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 100;
        /*
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        */ 
    }

    // Update is called once per frame
    void Update()
    {

        /*
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xSensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * ySensitivity;

        yRotation += mouseX;
        xRotation -= mouseY;
        // Make sure player can't look down or up more than 90 degrees
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Rotation of camera and orientation
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * walkingSpeed * verticalInput);
        */
    
    }

    public void decreaseHealth(int decAmount)
    {
        health -= decAmount;
    }

    public int getHealth()
    {
        return health;
    }
}
