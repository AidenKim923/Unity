using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetRotation : MonoBehaviour
{
    [SerializeField]
    public Transform targetTransform;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 direction = targetTransform.position - transform.position;
        Quaternion newRotation = Quaternion.LookRotation(direction);
        transform.rotation = newRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
