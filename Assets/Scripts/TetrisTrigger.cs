using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisTrigger : MonoBehaviour
{
    public GameObject[] Tetris;
    private void OnTriggerEnter(Collider other)
    {
        foreach(var block in Tetris)
            block.GetComponent<Rigidbody>().isKinematic = false;
    }
}
