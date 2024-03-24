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
            // ��ƼŬ �ý��� �������� ����
            ParticleSystem instance = Instantiate(explosionParticle, transform.position, transform.rotation);

            AudioSource explosionAudio = instance.GetComponent<AudioSource>();
            explosionAudio.Play();


            // ��ƼŬ ���� ���� �� �ı��ϰ�
            Destroy(instance.gameObject, instance.duration);
            // ������ ���� ���⶧���� ���ɸ� �� �����Ƿ� ���� ���� ����
            gameObject.SetActive(false);
        }
    }
}
