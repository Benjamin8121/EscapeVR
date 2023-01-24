using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Daddyfive : MonoBehaviour
{
    public GameObject Dor;
    public GameObject Dor2;
    public AudioSource audioData;
    public AudioSource door;

    void Start()
    {
        StartCoroutine(vent());
    }


    IEnumerator vent()
    {
        audioData.Play();
        yield return new WaitForSeconds(5);
        Dor.SetActive(true);
        door.Play();
        Dor2.SetActive(false);

    }
}
