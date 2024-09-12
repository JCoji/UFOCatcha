using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    /*
    private Vector3 _rotation;
    [SerializeField] private float _speed;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKey) {
            if (Input.GetKey(KeyCode.A))
            {
                _rotation = Vector3.left;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                _rotation = Vector3.right;
            }
            else if (Input.GetKey(KeyCode.W))
            {
                _rotation = Vector3.forward;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                _rotation = Vector3.back;
            }

            transform.Rotate(_rotation * _speed * Time.deltaTime);
            
        }
        else
        {
            _rotation = Vector3.zero;
        }
        

        
    }
    */

    public float moveSpeed = 5f;           // Speed of movement
    public float pitchSpeed = 700f;        // Speed of pitch rotation
    public float yawSpeed = 700f;          // Speed of yaw rotation

    private void Update()
    {
        // Get input from WASD and XY keys
        float pitchInput = Input.GetAxis("Vertical");   // W/S for pitch
        float yawInput = Input.GetAxis("Horizontal");   // X/Y for yaw

        // Calculate pitch and yaw rotation angles
        float pitch = pitchInput * pitchSpeed * Time.deltaTime;
        float yaw = yawInput * yawSpeed * Time.deltaTime;

        // Apply pitch rotation around the X-axis
        Transform transform = this.transform;
        transform.Rotate(Vector3.right, pitch);  // Rotate pitch (X-axis)

        // Apply yaw rotation around the Y-axis
        transform.Rotate(Vector3.up, yaw);  // Rotate yaw (Y-axis)

        // Optionally, move the object forward (optional)
        // Vector3 moveDirection = Vector3.forward * moveSpeed * Time.deltaTime;
        // transform.Translate(moveDirection);
    }
}
