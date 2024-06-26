using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
    public Rigidbody ball;
    public Transform firePos;
    public Slider powerSlider;

    public AudioSource shootingAudio;
    public AudioClip fireClip;
    public AudioClip chargingClip;

    public float minForce       = 15.0f;
    public float maxForce       = 30.0f;
    public float chargingTime   = 0.75f;

    private float currentForce;
    private float chargeSpeed;
    private bool fired;

    private void OnEnable()
    {
        currentForce = minForce;
        powerSlider.value = minForce;
        fired = false;
    }


    // Start is called before the first frame update
    void Start()
    {
        chargeSpeed = (maxForce - minForce) / chargingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (fired)
        {
            return;
        }

        if (currentForce >= maxForce && !fired)
        {
            currentForce = maxForce;
            Fire();
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            currentForce = minForce;
            shootingAudio.clip = chargingClip;
            shootingAudio.Play();
        }
        else if (Input.GetButton("Fire1") && !fired)
        {
            currentForce += chargeSpeed * Time.deltaTime;
            powerSlider.value = currentForce;
        }
        else if (Input.GetButtonUp("Fire1") && !fired)
        {
            Fire();
        }
    }

    private void Fire()
    {
        fired = true;

        Rigidbody ballInstance = Instantiate(ball, firePos.position, firePos.rotation);

        ballInstance.velocity = currentForce * firePos.forward;

        shootingAudio.clip = fireClip;
        shootingAudio.Play();

        currentForce = minForce;
    }
}
