using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlScript : MonoBehaviour
{
    AudioSource audio;
    public AudioClip[] clips;
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        StartCoroutine(introJingle());
    }

    private void playSound(int sound)
    {
        audio.clip = clips[sound];
        audio.Play();
    }

    private IEnumerator introJingle()
    {
        yield return new WaitForSeconds(3f);
        playSound(0);
        StartCoroutine(music());
    }

    private IEnumerator music()
    {
        yield return new WaitForSeconds(3f);
        playSound(1);
    }

    public void ChangeScence()
    {
        SceneManager.LoadScene("Main");
    }
}
