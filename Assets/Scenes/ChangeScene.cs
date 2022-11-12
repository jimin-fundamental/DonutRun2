using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{
   
    public void ChangeSceneBtn()
    {
        switch (this.gameObject.name)
        {
            case "StartButton":
                SceneManager.LoadScene("SampleScene");
                break;


        }


    }



}
