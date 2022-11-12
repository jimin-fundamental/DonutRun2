using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_fryingpan : MonoBehaviour
{
    public float speed = 3f;
    public float force;
    Rigidbody2D rigid;
    Vector2 startPos;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        ImpulseForce();
        MoveToPlayer1();
        Invoke("Deactive", 3);
        //Invoke("Active", 3);
    }

    void Deactive()
    {
        gameObject.SetActive(false);
    }

    void Active()
    {
        gameObject.SetActive(true);
    }

    void MoveToPlayer1()
    {
        rigid.AddForce(Vector2.right * force, ForceMode2D.Impulse);
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, startPos, 5);
    }

    void ImpulseForce()
    {
        force = Random.Range(0.1f, 0.5f);
    }
}
