using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelCtrl : MonoBehaviour
{
    public GameObject expEffect;

    private Transform tr;
    private Rigidbody rb;

    private int hitCount = 0;

    private void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("BULLET"))
        {
            if (++hitCount == 3)
            {
                ExpBarrel();    
            }
        }
    }

    private void ExpBarrel()
    {
        GameObject effect = Instantiate(expEffect, tr.position, Quaternion.identity);
        Destroy(effect, 1.0f);

        rb.mass = 1.0f;
        rb.AddForce(Vector3.up * 1500.0f);
        Destroy(gameObject, 3.0f);
    }
}
