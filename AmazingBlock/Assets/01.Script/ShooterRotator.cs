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

    private RotateState state = RotateState.Idle; // 초기 상태는 Idle
    [SerializeField]
    private float verticalRotateSpeed = 360.0f; // 수직 회전 속도
    [SerializeField]
    private float horizontalRotateSpeed = 360.0f; // 수평 회전 속도

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
                if (Input.GetButtonDown("Fire1")) // 누르는 순간
                {
                    state = RotateState.Horizontal; //  Horizontal 상태로 바꾸기
                }
                break;

            case RotateState.Horizontal:
                if (Input.GetButton("Fire1")) // 누르는 동안
                {
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));// 수평 방향으로 `회전시키기`
                }
                else if (Input.GetButtonUp("Fire1")) // 떼는 순간
                {
                    state = RotateState.Vertical; // Vertical 상태로 바꾸기
                }
                break;

            case RotateState.Vertical:
                if (Input.GetButton("Fire1")) // 누르는 동안
                {
                    transform.Rotate(new Vector3(-verticalRotateSpeed * Time.deltaTime, 0, 0));// 수직 방향으로 `회전시키기`. 뒤로 넘어지는 것처럼 회전 (마이너스)
                }
                else if (Input.GetButtonUp("Fire1")) // 떼는 순간
                {
                    state = RotateState.Ready; // Ready 상태로 바꾸기
                }
                break;

            case RotateState.Ready:
                break;
        }
    }
}
