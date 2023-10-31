using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifier : MonoBehaviour
{
    public delegate void Jump(int points);
    public event Jump OnJump;
     
    private void OnCollisionEnter(Collision collision)
    {
        if (OnJump != null && collision.gameObject.tag == "Spider")
        {
            // Cambio a la semana pasada
            Transform playerTransform = transform;
            Transform spiderTransform = collision.transform;
            if (playerTransform.position.y > 0.3)
            {
                OnJump(10);
            }
        }
    }
}
