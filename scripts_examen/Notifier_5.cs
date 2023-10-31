using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier_5 : MonoBehaviour
{
    public delegate void JumpChair();
    public event JumpChair OnJumpChair;
    
    public delegate void MoveBed();
    public event MoveBed OnMoveBed;

    private void OnCollisionEnter(Collision collision)
    {
        if(OnJumpChair != null && OnMoveBed != null && collision.gameObject.tag == "BedWithPerson")
        {
            OnJumpChair();
            OnMoveBed();
        }
    }
}
