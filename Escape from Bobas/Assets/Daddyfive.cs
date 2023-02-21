using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Daddyfive : MonoBehaviour
{
    public GameObject Dor;
    public GameObject Dor2;
    public AudioSource audioData;
    public AudioSource door;
    public AudioSource uhhuh;
    public AudioSource kommernu;

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
        yield return new WaitForSeconds(60);
        uhhuh.Play();
        yield return new WaitForSeconds(240);
        kommernu.Play();
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene(0);
    }
}

