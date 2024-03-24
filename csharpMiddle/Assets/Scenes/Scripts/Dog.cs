using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : MonoBehaviour
{
    public string nickname;
    public float weight;

    public static int count = 0;

    private void Awake()
    {
        count = count + 1;
    }

    private void Start()
    {
        Bark();
    }

    public void Bark()
    {
        Debug.Log("모든 개들의 수 : " + count);
        Debug.Log(nickname + " Bark!");
    }

    public static void ShowAnimalType()
    {
        Debug.Log("이것은 개입니다.");
    }
    
}
