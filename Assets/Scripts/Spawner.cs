using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;

    [SerializeField]
    private float motorForce;

    [SerializeField]
    private WheelCollider frontLeftWheelCollider;

    [SerializeField]
    private WheelCollider frontRightWheelCollider;

    private void FixedUpdate()
    {
        horizontalInput++;
        verticalInput++;
        frontLeftWheelCollider.motorTorque = verticalInput * motorForce;
        frontRightWheelCollider.motorTorque = verticalInput * motorForce;
    }
}
