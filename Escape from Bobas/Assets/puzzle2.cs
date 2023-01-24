using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle2 : MonoBehaviour
{
    public GameObject triangle;


    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("circkle"))
        {
            triangle.SetActive(true);
        }

    }
}
