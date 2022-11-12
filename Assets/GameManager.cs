using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int totalDonut=6;
    public static GameManager gameManager;
    GameObject ForDestroy; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (totalDonut == 5)
        {
            ForDestroy = GameObject.Find("donut");
            ForDestroy.SetActive(false);
        }
        else if (totalDonut == 4)
        {
            ForDestroy = GameObject.Find("donut1");
            ForDestroy.SetActive(false);
        }
        else if (totalDonut == 3)
        {
            ForDestroy = GameObject.Find("donut2");
            ForDestroy.SetActive(false);
        }
        else if (totalDonut == 2)
        {
            ForDestroy = GameObject.Find("donut3");
            ForDestroy.SetActive(false);
        }
        else if (totalDonut == 1)
        {
            ForDestroy = GameObject.Find("donut4");
            ForDestroy.SetActive(false);
        }
        


    }
}
