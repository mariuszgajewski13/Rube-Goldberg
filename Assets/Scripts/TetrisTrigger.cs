using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisTrigger : MonoBehaviour
{
    public GameObject[] Tetris;
    public ParticleSystem efect;
    private void OnTriggerEnter(Collider other)
    {
        efect.Play();
        foreach(var block in Tetris)
            block.GetComponent<Rigidbody>().isKinematic = false;
    }
}
