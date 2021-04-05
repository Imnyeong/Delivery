using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public int maxHealth = 10;

    Rigidbody2D rigid;
    SpriteRenderer spriteRenderer;
    Animator animator;

    Vector3 movement;
    bool isDie = false;
    float gx;
    static int Rnd;


    public int health = 10;


    // Use this for initialization
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponentInChildren<SpriteRenderer>();

        health = maxHealth;

        StartCoroutine("healthtimer");

    }

    // Update is called once per frame
    void Update()
    {
        if (health == 0)
        {
            if (!isDie)
                Die();
            return;
        }

        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if (pos.x < 0f) health = 0; ;//pos.x = 0f;
        if (pos.x > 1f) health = 0; ; //pos.x = 1f;
        transform.position = Camera.main.ViewportToWorldPoint(pos);

        gx = Input.acceleration.x * 19.0f;
        Physics2D.gravity = new Vector2(gx, 1);

        AnimationUpdate();

    }

    void FixedUpdate()
    {
        if (health == 0)
            return;

        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (gx > 0)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1);
        }

        else if (gx < 0)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    void AnimationUpdate()
    {
        if (-3 < gx && gx < 3)
        {
            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isMoving", true);
        }

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Oil")// 기름 먹은 경우
        {
            BlockStatus oil = other.gameObject.GetComponent<BlockStatus>();
            health = 10;
        }
        if (other.gameObject.tag == "Car")// 차에 부딪힌 경우
        {
            health = 0;
        }
    }



    void Die()
    {
        Setting.vibeon();
        isDie = true;
        ScoreManager.InsertRank(ScoreManager.getScore());
        rigid.velocity = Vector2.zero;
        GameManager.EndGame();
        setRnd();
    }

    void OnGUI()
    {
        GUIStyle myStyle = new GUIStyle();
        myStyle.fontSize = 50;
        myStyle.normal.textColor = Color.white;

        GUILayout.BeginArea(new Rect(0, 0, Screen.width, Screen.height));
        GUILayout.BeginHorizontal();
        GUILayout.Space(120);
        GUILayout.BeginVertical();
        GUILayout.Space(80);

        string heart = "";
        for (int i = 0; i < health; i++)
        {
            heart += "■";
        }
        GUILayout.Label(heart, myStyle);

        GUILayout.FlexibleSpace();
        GUILayout.EndVertical();
        GUILayout.FlexibleSpace();
        GUILayout.EndHorizontal();
        GUILayout.EndArea();
    }
    IEnumerator healthtimer()

    {

        while (true)
        {

            health--;
            yield return new WaitForSeconds(5);
        }

    }

    public static int getRnd()
    {
        return Rnd;
    }
    public static void setRnd()
    {
        Rnd = Random.Range(1, 100);
    }

}
