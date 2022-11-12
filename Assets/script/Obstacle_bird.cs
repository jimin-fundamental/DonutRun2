using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_bird : MonoBehaviour
{
    public GameObject[] obstacles;
    private bool touched = false;

    private void OnEnable() {
        touched = false;

        for(int i=0; i<obstacles.Length; i++) {
            if(Random.Range(0, 3) == 0) {
                obstacles[i].SetActive(true);
            }
            else
            {
                obstacles[i].SetActive(false);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "Player" && !touched) {
            touched = true;
            //GameManager.instance.AddScore(1);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}