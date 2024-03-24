using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    public int score = 5;
    public ParticleSystem explosionParticle;
    public float hp = 10f;

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if (hp <= 0)
        {
            // 파티클 시스템 동적으로 생성
            ParticleSystem instance = Instantiate(explosionParticle, transform.position, transform.rotation);

            AudioSource explosionAudio = instance.GetComponent<AudioSource>();
            explosionAudio.Play();


            // 파티클 수명 다한 후 파괴하게
            Destroy(instance.gameObject, instance.duration);
            // 프롭이 정말 많기때문에 렉걸릴 수 잇으므로 터진 프롭 끄기
            gameObject.SetActive(false);
        }
    }
}
