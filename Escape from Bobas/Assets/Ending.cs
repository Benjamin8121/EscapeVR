using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ending : MonoBehaviour
{

    public GameObject ClosedWindow;
    public GameObject OpenWindow;
    public GameObject Lock;
    private void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Key"))
        {
            ClosedWindow.SetActive (false);
            Lock.SetActive(false);
            OpenWindow.SetActive (true);
        }
    }
}
