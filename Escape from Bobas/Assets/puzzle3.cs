using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puzzle3 : MonoBehaviour
{
    public GameObject key;


    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("puzzle"))
        {
            key.SetActive(true);
        }

    }
}
