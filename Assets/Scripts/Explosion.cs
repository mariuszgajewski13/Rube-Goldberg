using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float radius = 100f;
    public float power = 10F;
    public ParticleSystem explosion;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        explosion.Play();
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();
            Debug.Log("BOOM");
            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 4);
        }
    }
}
