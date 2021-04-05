using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Speedup");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * speed * Time.deltaTime, 0);

        if (transform.position.y <= endPosition)
            ScrollEnd();
    }

    void ScrollEnd()
    {
        transform.Translate(0, -1 * (endPosition - startPosition), 0);

        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }
    IEnumerator Speedup()

    {

        while (true)
        {

            speed++;
            yield return new WaitForSeconds(20);
        }

    }
}


