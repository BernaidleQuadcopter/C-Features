using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean up code: CTRL+K+D

public class Movement : MonoBehaviour
{
    public float movementSpeed = 20f;
    public float rotationSpeed = 20f;


    // Update is called once per frame
    void Update()
    {
        // Check IF user presses W
        if (Input.GetKey(KeyCode.W))
        {
            // Move Up
            // 20 * 0.033 = 0.6
            transform.Translate(new Vector3(0, movementSpeed, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            // Move Up
            // 20 * 0.033 = 0.6
            transform.Translate(new Vector3(0, -movementSpeed, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // Move Up
            // 20 * 0.033 = 0.6
            transform.Translate(new Vector3(movementSpeed, 0 , 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // Move Up
            // 20 * 0.033 = 0.6
            transform.Translate(new Vector3(-movementSpeed, 0, 0) * Time.deltaTime);
        }
        {

        }
    }
}