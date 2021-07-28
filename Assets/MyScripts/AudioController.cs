using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource[] test;

    private void Start()
    {
        test = FindObjectsOfType<AudioSource>();
    }

    public void ChangeGlobalVolume(int volume)
    {
        foreach (AudioSource audio in test)
        {
            audio.volume -= Time.deltaTime;
        }
    }

}
