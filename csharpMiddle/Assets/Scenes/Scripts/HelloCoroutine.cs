using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCoroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("HelloUnity");
        StartCoroutine("HiCsharp");
        Debug.Log("End");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HelloUnity()
    {
        Debug.Log("Hello");

        yield return new WaitForSeconds(3.0f);

        Debug.Log("Coroutine!");
    }

    IEnumerator HiCsharp()
    {
        Debug.Log("Hi");

        yield return new WaitForSeconds(5.0f);

        Debug.Log("C#!");
    }
}
