using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetrisReset : MonoBehaviour
{
    public GameObject[] Tetris;
    Vector3[] position = new Vector3[4];

    private void Start()
    {
        position[0] = new Vector3(0f, 2.29999995f, -1.13999999f);
        position[1] = new Vector3(0f, 2.47000003f, -3.00099993f);
        position[2] = new Vector3(0, 1.79999995f, 1.29999995f);
        position[3] = new Vector3(0, 3.71000004f, -0.50999999f);
    }

    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < Tetris.Length; i++)
        {
            Tetris[i].GetComponent<Transform>().localPosition = position[i];
            Tetris[i].GetComponent<Rigidbody>().isKinematic = true;
        }
            
    }
}
