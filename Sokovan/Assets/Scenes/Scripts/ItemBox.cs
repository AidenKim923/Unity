using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;

    private Renderer Renderer;

    public Color touchColor;
    private Color originalColor; // private 이라 수정 불가능
    

    // Start is called before the first frame update
    void Start()
    {
        Renderer = GetComponent<Renderer>();
        originalColor = Renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // void OnTriggerEnter : 트리거 영역에 진입했을 때 호출되는 함수
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "EndPoint")
        //{
        //    Debug.Log("아이템 박스에 도달");
        //}

        //충돌한 오브젝트의 레이어의 이름이 EndPoint일 때
        if (other.gameObject.layer == LayerMask.NameToLayer("EndPoint"))
        {
            isOveraped = true;
            Renderer.material.color = touchColor;
            Debug.Log("아이템 박스에 도달");
        }
    }

    // void OnTriggerExit : 트리거 영역에서 나갔을 때 호출되는 함수
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("EndPoint"))
        {
            isOveraped = false;
            Renderer.material.color = originalColor;
            Debug.Log("아이템 박스에서 벗어남");
        }
    }

    // void OnTriggerStay : 트리거 영역에 머물러 있을 때 호출되는 함수
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("EndPoint"))
        {
            isOveraped = true;
            Renderer.material.color = touchColor;
        }
    }
}
