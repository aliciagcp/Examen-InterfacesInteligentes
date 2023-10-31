using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Cambio a la semana pasada
public class Movement_B : MonoBehaviour
{
    public float speed = 2f;

    Transform target;
    Transform point1;
    Transform point2;

    void Start()
    {
        point1 = new GameObject().transform;
        point1.position = new Vector3(Random.Range(-2, 5), 0f, Random.Range(-3, 1));

        point2 = new GameObject().transform;
        point2.position = new Vector3(Random.Range(-2, 5), 0f, Random.Range(-3, 1));

        target = point1;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (transform.position == target.position)
        {
            if (target == point1)
            {
                target = point2;
            }
            else
            {
                target = point1;
            }
        }
    }
}
