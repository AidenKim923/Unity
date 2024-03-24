using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        // If the left mouse button is clicked, add 5 to the score
        if (Input.GetMouseButtonDown(0))
        {
            ScoreManager.instance.AddScore(5);
            Debug.Log(ScoreManager.GetInstance().GetScore());
        }
    }
}
