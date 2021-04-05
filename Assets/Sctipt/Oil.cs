using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")// 플레이어와의 접촉
        {
            animator.SetBool("See", false); // 보이지 않게 한다.
        }
        if (other.gameObject.tag == "car")
        {
            return;
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("See", true);

        }
        if (other.gameObject.tag == "car")
        {
            return;
        }
    }

}
