using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public float minHeight;
    public float maxHeight;
    public float minWidth;
    public float maxWidth;
    public GameObject pivot;
    // Start is called before the first frame update
    void Start()
    {
        ChangeHeight();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ChangeHeight()
    {
        float height = Random.Range(minHeight, maxHeight);
        float width = Random.Range(minWidth, maxWidth);
        pivot.transform.localPosition = new Vector3(width, height, 0.0f);
    }

    void OnScrollEnd()
    {
        ChangeHeight();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Car")// 차끼리 겹칠 경우
        {
            ChangeHeight();
        }
    }

}

