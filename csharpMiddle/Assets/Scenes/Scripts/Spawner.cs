using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Rigidbody target;
    public GameObject target2;

    public Transform spawnPosition;
    public Transform spawnPosition2;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody instance = Instantiate(target, spawnPosition.position, spawnPosition.rotation);
        GameObject instance2 = Instantiate(target2, spawnPosition2.position, spawnPosition2.rotation);

        Debug.Log(instance.name);

        instance.AddForce(0, 1000, 0);
        // GetComponent를 사용하여 Rigidbody 컴포넌트를 가져옴
        instance2.GetComponent<Rigidbody>().AddForce(0, 1000, 0); 

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
