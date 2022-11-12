using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_move : MonoBehaviour
{
    [SerializeField]
    private float speed = 0.1f;
   
    void Start()
    {
        
    }

  
    void Update()
    {
      

       
            transform.Translate(new Vector3(3.2f * speed * Time.deltaTime, 0, 0));
            //times += Time.deltaTime;
     
        //낭떠러지에 떨어지거나 집으로 도착하면 멈추기 
    }
   // transform.position=position;
}
