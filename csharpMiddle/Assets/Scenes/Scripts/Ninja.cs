using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ninja : MonoBehaviour
{
    public static Ninja ninjaKing;

    public string ninjaName;
    public bool isKing;

    // Start is called before the first frame update
    void Start()
    {
        if (isKing)
        {
            ninjaKing = this;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("My name is " + ninjaName + ", Ninja King is " + ninjaKing);
    }
}
