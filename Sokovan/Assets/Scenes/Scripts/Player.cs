using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager GameManager;

    public float speed = 10f;
    Rigidbody Rigidbody;

    private void Awake()
    {
        Rigidbody = GetComponent<Rigidbody>();


        GameManager = FindObjectOfType<GameManager>();
        if (GameManager == null)
        {
            Debug.LogError("GameManager not found!");
        }
    }
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.isGameOver == true) // Ãß°¡
        {
            return;
        }

        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");

        float fallSpeed = Rigidbody.velocity.y;

        Vector3 velocity = new Vector3(inputX, -1, inputZ);
        velocity = velocity * speed;

        velocity.y = fallSpeed;

        Rigidbody.velocity = velocity;
    }
}
