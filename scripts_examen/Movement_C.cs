using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_C : MonoBehaviour
{
    public float jumpForce = 20f;
    private Rigidbody rb;
    bool isJumping;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isJumping = false;
    }

    void FixedUpdate()
    {
        if (isJumping == false)
        {
            Jump();
        }
        if (transform.position.y < 0.4)
        {
            isJumping = false;
        }
    }

    void Jump()
    {
        isJumping = true;
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
