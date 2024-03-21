using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // public 이므로 유니티에서 슬롯이 열린다.
    public Transform Transform;

    private void Start()
    {
        
    }

    private void Update()
    {
        Transform.Rotate(60 * Time.deltaTime, 60 * Time.deltaTime, 60 * Time.deltaTime);
    }
}
