using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modify : MonoBehaviour
{
    public GameObject spiderC;
    public GameObject spiderB;
    public GameObject bed1;
    public GameObject bed2;
    public float increaseSize = 1.5f;
    bool isViewSpider;

    private void Update()
    {
        if(isViewSpider)
        {
            IncreaseSizeSpider();
            OnBed();
        }
    }

    public void OnPointerEnter()
    {
        isViewSpider = true;
    }

    void OnPointerEnterExit()
    {
        isViewSpider = false;
    }

    private void IncreaseSizeSpider()
    {
        Vector3 scale = spiderC.transform.localScale;
        spiderC.transform.localScale = new Vector3(scale.x * increaseSize, scale.y * increaseSize, scale.z * increaseSize);
    }

    private void OnBed()
    {
        Vector3 position = new Vector3(0f, 0.75f, 0f);
        transform.position = bed1.transform.position + position;
        spiderC.transform.position = bed2.transform.position + position;
    }
}

