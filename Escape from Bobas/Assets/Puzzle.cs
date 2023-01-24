using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject circkle;


    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("square"))
        {
            circkle.SetActive(true);
        }

    }
}
