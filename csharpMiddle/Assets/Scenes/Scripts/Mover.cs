using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // ��������� ��� �������� ��ŭ �̵��� ������ ��Ÿ���� ����
    public Vector3 move = new Vector3(-5, -5, -5);

    // Start is called before the first frame update
    void Start()
    {
        // ��ġ�� ��Ÿ���� ������ǥ
        Vector3 targetPosition = new Vector3(1, 0, 0);

        transform.position = targetPosition;
        // move ���͸�ŭ �̵�
        transform.Translate(move);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
