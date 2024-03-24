using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager GetInstance()
    {
        if (instance == null)
        {
            instance = FindObjectOfType<ScoreManager>();
            
            // If the instance is still null, create a new GameObject and add the ScoreManager component to it
            if (instance == null)
            {
                // Create a new GameObject
                GameObject container = new GameObject("Score Manager");
                instance = container.AddComponent<ScoreManager>();
            }
        }
        return instance;
    }


    // 자기 자신을 참조할 static 변수
    // 자기 자신을 참조하게 할 것이다.
    
    [SerializeField]
    public static ScoreManager instance;

    [SerializeField]
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        // If there is already an instance of ScoreManager, destroy this object
        if (instance != null)
        {
            if (instance != null)
            {
                Destroy(gameObject);
            }
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int newScore)
    {
        score += newScore;
    }
}
