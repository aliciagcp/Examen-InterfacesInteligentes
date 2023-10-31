using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cambio a la semana pasada
public class movement_A : MonoBehaviour
{
    public Transform chair;
    public Transform table;
    public float speed = 2f;

    Transform target;

    void Start()
    {
        target = chair;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (transform.position == target.position)
        {
            if (target == chair)
            {
                target = table;
            }
            else
            {
                target = chair;
            }
        }
    }
}
