using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // public �̹Ƿ� ����Ƽ���� ������ ������.
    public Transform Transform;

    private void Start()
    {
        
    }

    private void Update()
    {
        Transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
    }
}
