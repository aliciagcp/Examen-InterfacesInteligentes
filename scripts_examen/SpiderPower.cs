using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderPower : MonoBehaviour
{
    float time = 0f;
    public float max = 3f;
    bool isPowerOnFire;

    private void Update()
    {
        if (time > max)
        {
            gameObject.SetActive(false);
        }
        else if(isPowerOnFire)
        {
            time += Time.deltaTime;
        }
    }

    public void OnPointerEnter()
    {
        isPowerOnFire = true;
    }

    void OnPointerEnterExit()
    {
        isPowerOnFire = false;
    }
}


