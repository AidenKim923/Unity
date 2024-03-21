using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOveraped = false;

    private Renderer Renderer;

    public Color touchColor;
    private Color originalColor; // private �̶� ���� �Ұ���
    

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

    // void OnTriggerEnter : Ʈ���� ������ �������� �� ȣ��Ǵ� �Լ�
    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "EndPoint")
        //{
        //    Debug.Log("������ �ڽ��� ����");
        //}

        //�浹�� ������Ʈ�� ���̾��� �̸��� EndPoint�� ��
        if (other.gameObject.layer == LayerMask.NameToLayer("EndPoint"))
        {
            isOveraped = true;
            Renderer.material.color = touchColor;
            Debug.Log("������ �ڽ��� ����");
        }
    }

    // void OnTriggerExit : Ʈ���� �������� ������ �� ȣ��Ǵ� �Լ�
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("EndPoint"))
        {
            isOveraped = false;
            Renderer.material.color = originalColor;
            Debug.Log("������ �ڽ����� ���");
        }
    }

    // void OnTriggerStay : Ʈ���� ������ �ӹ��� ���� �� ȣ��Ǵ� �Լ�
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("EndPoint"))
        {
            isOveraped = true;
            Renderer.material.color = touchColor;
        }
    }
}
