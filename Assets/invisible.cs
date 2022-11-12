using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float time = 0;
        time += Time.deltaTime;
        if (time == 1)
        {
            Destroy(gameObject);
        }
    }
}
