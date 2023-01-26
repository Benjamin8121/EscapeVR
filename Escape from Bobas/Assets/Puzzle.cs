using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{
    public GameObject circkle;
    public GameObject triangle;
    public GameObject key;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("square"))
        {
            circkle.SetActive(true);
        }
        if (other.CompareTag("circkle"))
        {
            triangle.SetActive(true);
        }
        if (other.CompareTag("triangle"))
        {
            key.SetActive(true);
        }
    }
}
