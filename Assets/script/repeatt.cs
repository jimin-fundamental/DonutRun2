using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repeatt : MonoBehaviour
{
    public float speed = 40.0f;
    public float startPosition;
    public float endPosition;

    void Update()
    {
        // x포지션을 조금씩 이동
        transform.Translate(-1 * speed * Time.deltaTime, 0, 0);

        // 목표 지점에 도달했다면
        if (transform.position.x <= endPosition)
        {
            ScrollEnd();
        }
    }

    void ScrollEnd()
    {
        // 원래 위치로 초기화 시킨다.
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
    }
}