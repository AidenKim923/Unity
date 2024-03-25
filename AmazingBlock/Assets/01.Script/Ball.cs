using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;

    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;

    public float maxDamage          = 100f;     // �ִ� ������
    public float explosionForce     = 1000f;    // ���� ��
    public float lifeTime           = 10f;      // �� ���� 10���̻� �ı� �ȵǸ� ������ �ı�
    public float explosionRadius    = 20f;      // ���� �ݰ�

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [System.Obsolete]
    private void OnTriggerEnter(Collider other)
    {
        Collider[] colliders =  Physics.OverlapSphere(transform.position, explosionRadius, whatIsProp);
        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();
            targetRigidbody.AddExplosionForce(explosionForce, transform.position, explosionRadius);

            Prop targetProp = colliders[i].GetComponent<Prop>();

            float damage = CalculateDamage(colliders[i].transform.position);
            targetProp.TakeDamage(damage);
        }

        explosionParticle.transform.parent = null;

        explosionParticle.Play();
        explosionAudio.Play();

        Destroy(explosionParticle.gameObject, explosionParticle.duration);
        Destroy(gameObject);
    }

    
    private float CalculateDamage(Vector3 targetPosition)
    {
        Vector3 explosionToTarget = targetPosition - transform.position;

        float distance              = explosionToTarget.magnitude;
        float edgeToCenterDistance  = explosionRadius - distance;
        float percentage            = edgeToCenterDistance / explosionRadius;
        float damage                = maxDamage * percentage;
        damage = Mathf.Max(0, damage);

        return damage;
    }
}
