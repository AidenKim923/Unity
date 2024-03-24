using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ShooterRotator : MonoBehaviour
{

    private enum RotateState
    {
        Idle,
        Vertical,
        Horizontal,
        Ready
    }

    private RotateState state = RotateState.Idle; // �ʱ� ���´� Idle
    [SerializeField]
    private float verticalRotateSpeed = 360.0f; // ���� ȸ�� �ӵ�
    [SerializeField]
    private float horizontalRotateSpeed = 360.0f; // ���� ȸ�� �ӵ�

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case RotateState.Idle:
                if (Input.GetButtonDown("Fire1")) // ������ ����
                {
                    state = RotateState.Horizontal; //  Horizontal ���·� �ٲٱ�
                }
                break;

            case RotateState.Horizontal:
                if (Input.GetButton("Fire1")) // ������ ����
                {
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));// ���� �������� `ȸ����Ű��`
                }
                else if (Input.GetButtonUp("Fire1")) // ���� ����
                {
                    state = RotateState.Vertical; // Vertical ���·� �ٲٱ�
                }
                break;

            case RotateState.Vertical:
                if (Input.GetButton("Fire1")) // ������ ����
                {
                    transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));// ���� �������� `ȸ����Ű��`. �ڷ� �Ѿ����� ��ó�� ȸ�� (���̳ʽ�)
                }
                else if (Input.GetButtonUp("Fire1")) // ���� ����
                {
                    state = RotateState.Ready; // Ready ���·� �ٲٱ�
                }
                break;

            case RotateState.Ready:
                break;
        }
    }
}
