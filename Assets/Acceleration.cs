using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public float rotationSpeed = 100f; // Adjust the speed of rotation as needed
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get input from the phone's rotation
        float rotationInput = Input.acceleration.x * rotationSpeed * Time.deltaTime;

        // Rotate the ball based on input
        transform.Rotate(Vector3.forward * rotationInput);
    }
}
