using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindArea : MonoBehaviour
{
    public float strenght;
    public Vector3 direction;
    public GameObject ball;

    private void OnTriggerEnter(Collider other)
    {
        Vector3 position = transform.position;
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb != null)
             rb.AddForce(direction*strenght);
        
    }
}
