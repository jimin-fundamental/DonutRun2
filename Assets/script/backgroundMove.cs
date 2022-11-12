using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMove : MonoBehaviour
{
    Rigidbody2D rigidback;
    public int backgroundSpeed;

    void Awake(){
        rigidback = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        rigidback.velocity = new Vector2(backgroundSpeed,rigidback.velocity.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
