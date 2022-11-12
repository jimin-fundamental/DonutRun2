using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{

    public GameManager gm; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void onCollisionEnter(Collision collision)
    {
        gm.totalDonut -= 1;
        Debug.Log("Destroy");
        collision.gameObject.SetActive(false);
        if (collision.gameObject.layer == 8) //bird
        {
            Debug.Log("Destroy");
            GameObject ForDestroy;
            ForDestroy = collision.gameObject;
            ForDestroy.SetActive(false);
            //collision.gameObject.SetActive(false);
        }


    }
}
