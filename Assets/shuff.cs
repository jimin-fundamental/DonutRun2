using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shuff : MonoBehaviour
{
    float rightMax = 2.0f; //좌로 이동가능한 (x)최대값

    float leftMax = -2.0f; //우로 이동가능한 (x)최대값

    float currentPosition; //현재 위치(x) 저장

    float direction = 3.0f; //이동속도+방향




    void Start()

    {

        currentPosition = transform.position.x;

    }




    void Update()

    {

        currentPosition += Time.deltaTime * direction;

        if (currentPosition >= rightMax)

        {

            direction *= -1;

            currentPosition = rightMax;

        }

        //현재 위치(x)가 우로 이동가능한 (x)최대값보다 크거나 같다면

        //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 우로 이동가능한 (x)최대값으로 설정

        else if (currentPosition <= leftMax)

        {

            direction *= -1;

            currentPosition = leftMax;

        }

        //현재 위치(x)가 좌로 이동가능한 (x)최대값보다 크거나 같다면

        //이동속도+방향에 -1을 곱해 반전을 해주고 현재위치를 좌로 이동가능한 (x)최대값으로 설정

        transform.position = new Vector3(currentPosition, 0, 0);

        //"Stone"의 위치를 계산된 현재위치로 처리

    }
}
