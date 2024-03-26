using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gyro : MonoBehaviour
{
    // Adjust rotation speed if needed
    public float rotationSpeed = 10f;

    void Start()
    {
        // Enable the gyroscope
        Input.gyro.enabled = true;
    }

    void Update()
    {
        // Get input from the gyroscope
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased;

        // Calculate rotation input
        float rotationInput = gyroInput.z * rotationSpeed * Time.deltaTime;

        // Rotate the object based on input
        transform.Rotate(Vector3.forward * rotationInput);
    }
}
