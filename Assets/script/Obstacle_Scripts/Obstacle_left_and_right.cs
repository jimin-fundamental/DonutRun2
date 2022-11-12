using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_up_and_down : MonoBehaviour
{
    public float speed = 3f;
    bool switc = true;
    private SpriteRenderer spriteRenderer;
    Vector2 pos;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        pos = transform.position;
    }

    void Update()
    {
        if (switc)
        {
            movebirdup();
        }
        else
        {
            movebirddown();
        }

        if (transform.position.y >= pos.y + 2)
        {
            switc = false;
        }
        else if (transform.position.y <= pos.y - 1)
        {
            switc = true;
        }
    }

    void movebirdup()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    void movebirddown()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
    }
}
