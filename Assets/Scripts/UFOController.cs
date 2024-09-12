using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class UFOController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // Movement speed
    public float rotationSpeed = 700.0f; // Rotation speed in degrees per second

    private Rigidbody rb;

    void Start()
    {
        // Get the Rigidbody component attached to the player
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Get input from WASD keys
        float moveVertical = Input.GetAxis("Vertical");
        float rotateHorizontal = Input.GetAxis("Horizontal");

        // Create a movement vector
        Vector3 movement = transform.forward * moveVertical * moveSpeed * Time.deltaTime;

        // Apply movement to the Rigidbody
        rb.MovePosition(rb.position + movement);

        // Create a rotation vector
        float rotation = rotateHorizontal * rotationSpeed * Time.deltaTime;

        // Apply rotation
        rb.MoveRotation(rb.rotation * Quaternion.Euler(0, rotation, 0));
    }
}
