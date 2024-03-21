using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // 상대적으로 어느 방향으로 얼만큼 이동할 것인지 나타내는 벡터
    public Vector3 move = new Vector3(-5, -5, -5);

    // Start is called before the first frame update
    void Start()
    {
        // 위치를 나타내는 절대좌표
        Vector3 targetPosition = new Vector3(1, 0, 0);

        transform.position = targetPosition;
        // move 벡터만큼 이동
        transform.Translate(move);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
