using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> scores = new List<int>(); // ����Ʈ

    private void Start()
    {
        while (scores.Count > 0)
        {
            scores.RemoveAt(0);
        }
    }
}
