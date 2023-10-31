using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpChair : MonoBehaviour
{
    private void Start()
    {
        FindObjectOfType<Notifier_5>().OnJumpChair += Jump;
    }

    private void Jump()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.up * 10f, ForceMode.Impulse);
    }
}
