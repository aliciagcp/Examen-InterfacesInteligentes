using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBed : MonoBehaviour
{
    public float displacementAmount = 2f;
    public float speed = 2f;
    Vector3 target;
    Vector3 oldPosition;
    Vector3 newPosition;
    bool isMoving;

    void Start()
    {
        isMoving = false;
        oldPosition = transform.position;
        newPosition = transform.position;
        newPosition += new Vector3(0f, 0f, -displacementAmount);
        target = newPosition;
        FindObjectOfType<Notifier_5>().OnMoveBed += Move;
    }

    void Update()
    {
        if (isMoving) 
        {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
            if (transform.position == target)
            {
                if (target == newPosition)
                {
                    target = oldPosition;
                }
                else
                {
                    target = newPosition;
                }
            }
        }
    }

    void Move()
    {
        isMoving = true;
    }
}
